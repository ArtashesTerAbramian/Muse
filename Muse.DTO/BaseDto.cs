// Ignore Spelling: Linkedin Instagram Dto

namespace Muse.DTO;

public record BaseDto
{
    public long Id { get; set; }
}

public record BaseDtoWithDate : BaseDto
{
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate { get; set; }
}