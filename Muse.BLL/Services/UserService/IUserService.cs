using Ardalis.Result;
using Muse.BLL.Filters;
using Muse.DTO;
using Muse.DTO.UserDtos;

namespace Muse.BLL.Services.UserService;

public interface IUserService
{
    Task<Result<UserGetByIdDto>> GetById(long id);
    Task<PagedResult<List<UserDto>>> GetAll(UserFilter filter);
    Task<Result<BaseDto>> Add(AddUserDto addUserDto);
    Task<Result> Update(UpdateUserDto updateUserDto);
    Task<Result> Delete(long id);

}