namespace Muse.DAL.Models;

public class ErrorTranslation : BaseTranslationEntity
{
    public long ErrorId { get; set; }
    public string Name { get; set; } = default!;
    public Error Error { get; set; }
    public Language Language { get; set; }
}