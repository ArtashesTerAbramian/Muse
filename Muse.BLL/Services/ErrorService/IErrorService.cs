using Ardalis.Result;
using Muse.DTO;

namespace Muse.BLL.Services.ErrorService;
public interface IErrorService
{
    Task<Result<ErrorModelDto>> GetById(long id);
    Task<string> GetErrorName(long id);
}