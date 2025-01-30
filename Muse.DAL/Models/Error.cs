namespace Muse.DAL.Models;

public class Error : BaseEntity
{
    public Error()
    {
        Translations = new HashSet<ErrorTranslation>();
    }

    public ICollection<ErrorTranslation> Translations { get; set; }
}
