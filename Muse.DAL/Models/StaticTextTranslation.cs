namespace Muse.DAL.Models;

public class StaticTextTranslation : BaseTranslationEntity
{
    public long StaticTextId { get; set; }
    public string Name { get; set; } = default!;

    public StaticText StaticText { get; set; }
}