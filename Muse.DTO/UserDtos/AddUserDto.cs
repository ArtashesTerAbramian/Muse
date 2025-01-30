namespace Muse.DTO.UserDtos;

public record AddUserDto
{
    public string FirstName { get; set; } = default!;
    public string? LastName { get; set; }
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public required string Phone { get; set; } = default!;
    public long RoleId { get; set; }
    public long? DefaultLanguageId { get; set; }
    public FileDto? Photo { get; set; }
}