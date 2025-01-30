namespace Muse.DTO.UserDtos;

public record ChangeBasePasswordDto
{
    public string OldPassword { get; set; } = default!;
    public string NewPassword { get; set; } = default!;
}