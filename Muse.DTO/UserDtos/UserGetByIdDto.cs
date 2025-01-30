namespace Muse.DTO.UserDtos;

public record UserGetByIdDto : BaseDto
{
    public string Name { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string? Phone { get; set; }
    public bool EmailIsVerified { get; set; }
    public bool BasePasswordIsChanged { get; set; }
    public long RoleId { get; set; }

    public List<long>? PermissionIds { get; set; }
}