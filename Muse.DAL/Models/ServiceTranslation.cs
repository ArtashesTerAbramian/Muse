namespace Muse.DAL.Models;

public class ServiceTranslation : BaseTranslationEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
 
    public long ServiceId { get; set; }
    public Service Service { get; set; }
}