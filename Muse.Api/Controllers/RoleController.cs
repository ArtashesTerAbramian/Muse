using Ardalis.Result;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Filters;
using Muse.BLL.Services.RoleService;
using Muse.DTO;
using Muse.DTO.RoleDtos;

namespace Muse.Api.Controllers;

public class RoleController : ApiControllerBase
{
    private readonly IRoleService _roleService;

    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet("get-by-id")]
    public async Task<Result<RoleDto>> GetById(long id)
    {
        return await _roleService.GetById(id);
    }

    [HttpGet("get-all")]
    public async Task<PagedResult<List<RoleDto>>> GetAll([FromQuery] RoleFilter filter)
    {
        return await _roleService.GetAll(filter);
    }
}