using Ardalis.Result;
using CryptoHelper;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Constants;
using Muse.BLL.Enums;
using Muse.BLL.Filters;
using Muse.BLL.Helpers;
using Muse.BLL.Models;
using Muse.BLL.Services.ErrorService;
using Muse.DAL;
using Muse.DAL.Models;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.BLL.Services.UserService;

public class UserService : IUserService
{
    private readonly AppDbContext _db;
    private readonly IUserSessionService _userSessionService;
    private readonly IErrorService _errorService;
    private readonly FileHelper _fileHelper;

    public UserService(AppDbContext db, IUserSessionService userSessionService, IErrorService errorService, FileHelper fileHelper)
    {
        _db = db;
        _userSessionService = userSessionService;
        _errorService = errorService;
        _fileHelper = fileHelper;
    }

    public Task<Result<UserGetByIdDto>> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<List<UserDto>>> GetAll(UserFilter filter)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<BaseDto>> Add(AddUserDto addUserDto)
    {
        if (await _db.Users.AnyAsync(x => x.Email == addUserDto.Email.ToLower().Trim()))
        {
            return Result.Error(await _errorService.GetErrorName(ErrorConstants.GivenEmailAlreadyUsed));
        }

        // if (await _db.Users.AnyAsync(x => x.Phone == addUserDto.Phone.Trim()))
        // {
        // return Result.Error(await _errorService.GetErrorName(ErrorConstants.Phone));
        // }

        var user = new User
        {
            Name = addUserDto.FirstName,
            Email = addUserDto!.Email.ToLower().Trim(),
            PasswordHash = Crypto.HashPassword(addUserDto.Password),
            Phone = addUserDto.Phone,
            RoleId = addUserDto.RoleId,
            DefaultLanguageId = addUserDto.DefaultLanguageId is null || !(addUserDto.DefaultLanguageId.Value > 0)
                ? (int)LanguageEnum.English
                : addUserDto.DefaultLanguageId.Value,
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();
        
        if (addUserDto.Photo is not null)
        {
            user.Phone = await _fileHelper.UploadFile(addUserDto.Photo!, FileConstants.UserPhotos,
                Path.Combine("1", user.Id.ToString()));
        }

        return new BaseDto
        {
            Id = user.Id
        };
    }

    public Task<Result> Update(UpdateUserDto updateUserDto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> Delete(long id)
    {
        throw new NotImplementedException();
    }
}