using Muse.DTO.RoleDtos;

namespace Muse.DTO.UserDtos;

public record UserDto : BaseDto
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public long RoleId { get; set; }
    public RoleDto Role { get; set; }
}