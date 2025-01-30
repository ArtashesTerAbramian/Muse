namespace Muse.DTO.RoleDtos;

public record RoleDto : BaseDto
{
    public string? Name { get; set; }
    public List<long>? PermissionIds { get; set; } 
}