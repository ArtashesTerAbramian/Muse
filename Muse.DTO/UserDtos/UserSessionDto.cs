namespace Muse.DTO.UserDtos;

public record UserSessionDto
{
    public long UserId { get; set; }
    public string Token { get; set; } = default!;
    public bool IsExpired { get; set; }
    // public UserDto User { get; set; }
}