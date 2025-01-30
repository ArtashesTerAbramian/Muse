namespace Muse.DAL.Models;

public class ServiceSpecificationTranslation : BaseTranslationEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required long ServiceId { get; set; }

    public Service Service { get; set; }
}