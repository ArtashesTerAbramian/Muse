namespace Muse.DTO.UserDtos;

public record UpdateUserDto : BaseDto
{
    public string Name { get; set; } = default!;
    public string? NewPassword { get; set; }
    public string UserName { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public long RoleId { get; set; }
}