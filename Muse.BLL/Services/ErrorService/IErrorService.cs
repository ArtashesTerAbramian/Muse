using Muse.DTO;

namespace Muse.BLL.Services.ErrorService;
public interface IErrorService
{
    Task<ErrorModelDto> GetById(long id);
}