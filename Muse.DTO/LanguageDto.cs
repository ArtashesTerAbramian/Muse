namespace Muse.DTO;

public record LanguageDto : BaseDto
{
    public string Name { get; set; } = default!;
    public string Code { get; set; } = default!;
    public string PhotoName { get; set; } = default!;
    public string Link { get; set; } = default!;
    public bool IsDefault { get; set; }
    public bool IsActive { get; set; }
}