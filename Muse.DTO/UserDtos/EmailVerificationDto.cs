namespace Muse.DTO.UserDtos;

public record EmailVerificationDto
{
    public string Token { get; set; } = default!;
}