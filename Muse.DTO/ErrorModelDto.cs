// Ignore Spelling: Linkedin Instagram Dto

namespace Muse.DTO;

public record ErrorModelDto
{
    public long Code { get; set; }
    public string Description { get; set; }
    public string Key { get; set; }
}
