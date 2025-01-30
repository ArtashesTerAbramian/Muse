namespace Muse.DAL.Models;

public class Permission : BaseEntity
{
    public Permission()
    {
        Translations = new HashSet<PermissionTranslation>();
    }

    public string Value { get; set; }

    public ICollection<PermissionTranslation>? Translations { get; set; }
}