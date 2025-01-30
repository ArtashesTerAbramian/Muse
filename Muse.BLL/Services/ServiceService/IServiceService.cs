using Ardalis.Result;
using Muse.DTO.ServiceDtos;

namespace Muse.BLL.Services.ServiceService;

public interface IServiceService
{
    Task<Result<ServiceDto>> GetById(long id);
    Task<PagedResult<List<ServiceDto>>> GetAllAsync();
}