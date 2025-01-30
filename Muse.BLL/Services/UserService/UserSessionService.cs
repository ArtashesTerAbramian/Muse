using Ardalis.Result;
using CryptoHelper;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Muse.BLL.Constants;
using Muse.BLL.Enums;
using Muse.BLL.Mappers;
using Muse.BLL.Models;
using Muse.BLL.Services.ErrorService;
using Muse.BLL.Services.MailService;
using Muse.DAL;
using Muse.DAL.Models;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.BLL.Services.UserService;

public class UserSessionService : IUserSessionService
{
    private readonly AppDbContext _db;
    private readonly IErrorService _errorService;
    private readonly IHttpContextAccessor _httpContext;
    private readonly LinkOptions _linkOptions;
    private readonly AuthOptions _options;

    public UserSessionService(AppDbContext db,
        IHttpContextAccessor httpContext,
        IOptions<AuthOptions> options,
        IErrorService errorService, 
        IOptions<LinkOptions> linkOptions)
    {
        _db = db;
        _httpContext = httpContext;
        _options = options.Value;
        _errorService = errorService;
        _linkOptions = linkOptions.Value;
    }

    public User CurrentUser { get; private set; }


    public async Task<Result<UserSessionDto>> Login(LoginDto dto)
    {
        var dbUser = await _db.Users.FirstOrDefaultAsync(x => x.Email == dto.Email.ToLower().Replace(" ", ""));

        if (dbUser == null || !Crypto.VerifyHashedPassword(dbUser.PasswordHash, dto.Password))
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.TheUsernameOrPasswordIsIncorrect));
        }

        if (!dbUser.EmailIsVerified)
        {
            await EmailVerificationRequest(dbUser.Email);

            return Result.Error(await _errorService.GetErrorName(ErrorConstants.EmailNotVerified));
        }

        var token = Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");

        var session = new UserSession
        {
            Token = token,
            UserId = dbUser.Id
        };

        _db.UserSessions.Add(session);

        await _db.SaveChangesAsync();

        var userSession = await _db.UserSessions.Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == session.Id);

        return userSession.MapToDto();
    }

    public async Task<Result> LogOut()
    {
        _httpContext.HttpContext.Request.Headers.TryGetValue(HeaderNames.Authorization, out var token);

        var session = await _db.UserSessions.FirstOrDefaultAsync(x => x.Token == token.ToString());

        if (session != null)
        {
            session.IsExpired = true;
            session.IsDeleted = true;

            await _db.SaveChangesAsync();
        }

        return Result.Success();
    }

    public async Task<Result> ForgetPasswordRequest(ForgetPasswordDto passwordDto)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == passwordDto.UserName.ToLower());

        if (user is null)
        {
            return Result.NotFound();
        }

        // if (!user.EmailIsVerified || !user.BasePasswordIsChanged)
        // {
        //     return Result.Error(await _errorService.GetErrorName(ErrorConstants.PleaseContactYourSystemAdmin));
        // }

        user.ResetPasswordToken = Guid.NewGuid().ToString("N");
        user.ResetPasswordRequestDate = DateTime.UtcNow;

        var link = string.Concat(_linkOptions.WebSiteUrl, _linkOptions.UserResetPassword, user.ResetPasswordToken);

        var mailQueue = new MailQueue
        {
            UserId = user.Id,
            Subject = EmailConstants.ResetPassword,
            Text = EmailConstants.HtmlText.Replace("{link}", link),
            Contact = user.Email
        };

        _db.MailQueues.Add(mailQueue);
        await _db.SaveChangesAsync();

        BackgroundJob.Enqueue<IMailSenderService>(x => x.SendEmail(mailQueue.Id));

        return Result.Success();
    }

    public async Task<Result<UserDto>> ChangeBasePassword(ChangeBasePasswordDto dto)
    {
        if (!Crypto.VerifyHashedPassword(CurrentUser.PasswordHash, dto.OldPassword))
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.CurrentPasswordIsIncorrect));
        }

        if (Crypto.VerifyHashedPassword(CurrentUser.PasswordHash, dto.NewPassword))
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.TheOldPasswordCannotBeUsed));
        }

        CurrentUser.PasswordHash = Crypto.HashPassword(dto.NewPassword);
        CurrentUser.BasePasswordIsChanged = true;

        await _db.SaveChangesAsync();

        return CurrentUser.MapToDto();
    }

    public async Task<Result<UserSessionDto>> ChangePasswordByEmail(ChangePasswordDto dto)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.ResetPasswordToken == dto.Code);

        if (user == null)
        {
            return Result.NotFound();
        }

        if (Crypto.VerifyHashedPassword(user.PasswordHash, dto.Password))
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.CurrentPasswordIsIncorrect));
        }

        if (user.ResetPasswordRequestDate != null && user.ResetPasswordRequestDate.Value.AddDays(1) < DateTime.UtcNow)
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.PasswordVerificationLinkExpired));
        }

        user.PasswordHash = Crypto.HashPassword(dto.Password);
        user.ResetPasswordToken = null;
        user.ResetPasswordRequestDate = null;

        var newToken = Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");

        var existedSessions =
            await _db.UserSessions.Where(x => x.UserId == user.Id && x.IsExpired == false).ToListAsync();
        existedSessions.ForEach(us => us.IsExpired = true);

        var session = new UserSession
        {
            Token = newToken,
            UserId = user.Id
        };

        _db.UserSessions.Add(session);

        await _db.SaveChangesAsync();

        var userSession = await _db.UserSessions
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Id == session.Id);

        return userSession.MapToDto();
    }

    public async Task<Result> EmailVerificationRequest(string email)
    {
        var dbUser = await _db.Users.FirstOrDefaultAsync(x => x.Email == email && x.EmailVerificationToken == null);

        if (dbUser is null)
        {
            return Result.NotFound();
        }

        dbUser.EmailVerificationToken = Guid.NewGuid().ToString("N");
        dbUser.EmailVerificationRequestDate = DateTime.UtcNow;

        var link = string.Concat(_linkOptions.WebSiteUrl, _linkOptions.UserEmailVerification,
            dbUser.EmailVerificationToken);

        var mailQueue = new MailQueue
        {
            UserId = dbUser.Id,
            Subject = EmailConstants.VerifyEmail,
            Text = EmailConstants.HtmlText.Replace("{link}", link),
            Contact = dbUser.Email
        };

        _db.MailQueues.Add(mailQueue);
        await _db.SaveChangesAsync();

        BackgroundJob.Enqueue<IMailSenderService>(x => x.SendEmail(mailQueue.Id));
        
        return Result.Success();
    }

    public async Task<Result> EmailVerification(EmailVerificationDto dto)
    {
        var dbUser = await _db.Users.FirstOrDefaultAsync(x => x.EmailVerificationToken == dto.Token);

        if (dbUser == null)
        {
            return Result.NotFound();
        }

        if (dbUser.EmailVerificationRequestDate != null && dbUser.EmailVerificationRequestDate.Value.AddDays(1) < DateTime.UtcNow)
        {
            dbUser.EmailVerificationToken = Guid.NewGuid().ToString("N");
            dbUser.EmailVerificationRequestDate = DateTime.UtcNow;

            var link = string.Concat(_linkOptions.WebSiteUrl, _linkOptions.UserEmailVerification,
                dbUser.EmailVerificationToken);

            var mailQueue = new MailQueue
            {
                UserId = dbUser.Id,
                Subject = EmailConstants.VerifyEmail,
                Text = EmailConstants.HtmlText.Replace("{link}", link),
                Contact = dbUser.Email
            };

            _db.MailQueues.Add(mailQueue);
            await _db.SaveChangesAsync();
            
            BackgroundJob.Enqueue<IMailSenderService>(x => x.SendEmail(mailQueue.Id));

            return Result.Error(await _errorService.GetErrorName(ErrorConstants.EmailVerificationLinkExpired));
        }

        dbUser.EmailVerificationToken = null;
        dbUser.EmailVerificationRequestDate = null;

        dbUser.EmailIsVerified = true;
        await _db.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<UserDto> GetByToken(string token)
    {
        var userSession = await _db.UserSessions
            .Include(x => x.User)
            // .ThenInclude(x => x.Role)
            // .Include(x => x.User)
            .ThenInclude(x => x.Role)
            .ThenInclude(x => x.Permissions)
            .FirstOrDefaultAsync(x => x.Token == token
                                      && !x.IsExpired);


        if (userSession is null)
        {
            return null;
        }

        CurrentUser = userSession.User;

        if (userSession.ModifyDate.Value.AddMinutes(_options.UserTokenExpirationTimeInMinutes) < DateTime.Now)
        {
            userSession.IsExpired = true;

            await _db.SaveChangesAsync();

            return null;
        }

        userSession.ModifyDate = DateTime.UtcNow;

        await _db.SaveChangesAsync();

        var userDto = userSession.User.MapToDto();

        return userDto;
    }

    public async Task<bool> HasPermission(string requestPath)
    {
        if (CurrentUser == null)
        {
            return true;
        }

        //TODO Remove FullPermission
        if (CurrentUser is not null && CurrentUser.RoleId == (long)UserRoleEnum.Admin)
        {
            return true;
        }

        var permission = await _db.Permissions
            .FirstOrDefaultAsync(x => x.Value != null && requestPath.ToLower().EndsWith(x.Value.ToLower()));

        if (permission is not null && !CurrentUser.Role.Permissions.Any(x => x.PermissionId == permission.Id))
        {
            return false;
        }

        return true;
    }
}