using Ardalis.Result;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Filters;
using Muse.BLL.Services.PermissionService;
using Muse.DTO.PermissionDtos;

namespace Muse.Api.Controllers;

public class PermissionController : ApiControllerBase
{
    private readonly IPermissionService _permissionService;

    public PermissionController(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    [HttpGet("get-by-id")]
    public async Task<Result<PermissionDto>> GetById(long id)
    {
        return await _permissionService.GetById(id);
    }

    [HttpGet("get-all")]
    public async Task<PagedResult<List<PermissionDto>>> GetAll([FromQuery] PermissionFilter filter)
    {
        return await _permissionService.GetAll(filter);
    }
}