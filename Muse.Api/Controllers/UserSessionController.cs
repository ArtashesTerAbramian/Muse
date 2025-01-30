using Ardalis.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Attributes;
using Muse.BLL.Services.UserService;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.Api.Controllers;

public class UserSessionController : ApiControllerBase
{
    private readonly IUserSessionService _userSessionService;

    public UserSessionController(IUserSessionService userSessionService)
    {
        _userSessionService = userSessionService;
    }

    [AllowAnonymous]
    [SkipPermissionCheck]
    [HttpPost("login")]
    public async Task<Result<UserSessionDto>> Login(LoginDto dto)
    {
        return await _userSessionService.Login(dto);
    }

    [SkipPermissionCheck]
    [HttpPost("log-out")]
    public async Task<Result> LogOut()
    {
        return await _userSessionService.LogOut();
    }

    [AllowAnonymous]
    [HttpPost("forget-password")]
    public async Task<Result<UserSessionDto>> ForgetPasswordRequest(ForgetPasswordDto dto)
    {
        return await _userSessionService.ForgetPasswordRequest(dto);
    }

    [SkipPermissionCheck]
    [HttpPost("change-base-password")]
    public async Task<Result<UserDto>> ChangeBasePassword(ChangeBasePasswordDto dto)
    {
        return await _userSessionService.ChangeBasePassword(dto);
    }

    [AllowAnonymous]
    [HttpPost("change-password")]
    public async Task<Result<UserSessionDto>> ChangePassword(ChangePasswordDto dto)
    {
        return await _userSessionService.ChangePasswordByEmail(dto);
    }

    [AllowAnonymous]
    [SkipPermissionCheck]
    [HttpPost("verify-email")]
    public async Task<Result> VerifyEmail([FromBody] EmailVerificationDto dto)
    {
        return await _userSessionService.EmailVerification(dto);
    }
}