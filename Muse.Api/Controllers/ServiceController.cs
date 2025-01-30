using Ardalis.Result;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Attributes;
using Muse.BLL.Services.ServiceService;
using Muse.DTO.ServiceDtos;

namespace Muse.Api.Controllers;

[SkipPermissionCheck]
public class ServiceController : ApiControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    [HttpGet("get-by-id")]
    public async Task<Result<ServiceDto>> GetByIdAsync(long id)
    {
        return await _serviceService.GetById(id);
    }

    [HttpGet("get-all")]
    public async Task<PagedResult<List<ServiceDto>>> GetAllAsync()
    {
        return await _serviceService.GetAllAsync();
    }
}