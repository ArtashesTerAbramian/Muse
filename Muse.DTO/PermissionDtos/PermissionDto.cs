namespace Muse.DTO.PermissionDtos;

public record PermissionDto : BaseDto
{
    public string Value { get; set; }
    public string Name { get; set; } = default!;
}