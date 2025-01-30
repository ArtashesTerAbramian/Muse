namespace Muse.DAL.Models;

public class StaticText : BaseEntity
{
    public StaticText()
    {
        Translations = new HashSet<StaticTextTranslation>();
    }

    public string Key { get; set; } = default!;

    public ICollection<StaticTextTranslation> Translations { get; set; }
}