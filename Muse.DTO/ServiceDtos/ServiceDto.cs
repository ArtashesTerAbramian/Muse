namespace Muse.DTO.ServiceDtos;

public record ServiceDto : BaseDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
}