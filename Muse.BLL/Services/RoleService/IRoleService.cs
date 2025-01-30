using Ardalis.Result;
using Muse.BLL.Filters;
using Muse.DTO;
using Muse.DTO.RoleDtos;

namespace Muse.BLL.Services.RoleService;

public interface IRoleService
{
    Task<Result<RoleDto>> GetById(long id);
    Task<PagedResult<List<RoleDto>>> GetAll(RoleFilter filter);
}