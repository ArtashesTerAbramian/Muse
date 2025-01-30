namespace Muse.DTO.UserDtos;

public record ForgetPasswordDto
{
    public string UserName { get; set; } = default!;
}