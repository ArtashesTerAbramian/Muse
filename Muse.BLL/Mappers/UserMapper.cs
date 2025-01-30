using Muse.DAL.Models;
using Muse.DTO.UserDtos;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class UserMapper
{
    public static partial UserDto MapToDto(this User user);
    public static partial List<UserDto> MapToDto(this List<User> users);
    public static partial UserSessionDto MapToDto(this UserSession user);

}