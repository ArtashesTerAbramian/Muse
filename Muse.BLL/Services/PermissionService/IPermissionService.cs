using Ardalis.Result;
using Muse.BLL.Filters;
using Muse.DTO.PermissionDtos;
using Muse.DTO.RoleDtos;

namespace Muse.BLL.Services.PermissionService;

public interface IPermissionService
{
    Task<Result<PermissionDto>> GetById(long id);
    Task<PagedResult<List<PermissionDto>>> GetAll(PermissionFilter filter);

}