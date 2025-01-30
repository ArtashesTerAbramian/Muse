using Ardalis.Result;
using Muse.DAL.Models;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.BLL.Services.UserService;

public interface IUserSessionService
{
    User CurrentUser { get; }
    Task<Result<UserSessionDto>> Login(LoginDto dto);
    Task<Result> LogOut();
    Task<Result> ForgetPasswordRequest(ForgetPasswordDto dto);
    Task<Result<UserDto>> ChangeBasePassword(ChangeBasePasswordDto dto);
    Task<Result<UserSessionDto>> ChangePasswordByEmail(ChangePasswordDto dto);
    Task<UserDto> GetByToken(string token);
    Task<Result> EmailVerificationRequest(string email);
    Task<Result> EmailVerification(EmailVerificationDto dto);
    Task<bool> HasPermission(string requestPath);
}