namespace Muse.DAL.Models;

public class Role : BaseEntity
{
    public Role()
    {
        Translations = new HashSet<RoleTranslation>();
    }

    public ICollection<RoleTranslation>? Translations { get; set; }
    public ICollection<RolePermission>? Permissions { get; set; }
}