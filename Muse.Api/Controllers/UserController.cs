using Ardalis.Result;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Attributes;
using Muse.BLL.Filters;
using Muse.BLL.Services.UserService;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.Api.Controllers;

public class UserController : ApiControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [SkipPermissionCheck]
    [HttpGet("get-by-id")]
    public async Task<Result<UserGetByIdDto>> GetById(long id)
    {
        return await _userService.GetById(id);
    }

    [HttpGet("get-all")]
    public async Task<PagedResult<List<UserDto>>> GetById([FromQuery] UserFilter filter)
    {
        return await _userService.GetAll(filter);
    }


    [HttpPost("add")]
    public async Task<Result<BaseDto>> Create(AddUserDto userDto)
    {
        return await _userService.Add(userDto);
    }

    [HttpPost("update")]
    public async Task<Result<UserDto>> Update(UpdateUserDto userDto)
    {
        return await _userService.Update(userDto);
    }

    [HttpPost("delete")]
    public async Task<Result> Delete(BaseDto userDto)
    {
        return await _userService.Delete(userDto.Id);
    }
}