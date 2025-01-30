namespace Muse.DTO.UserDtos;

public record ChangePasswordDto
{
    public string Code { get; set; } = default!;
    public string Password { get; set; } = default!;
}