namespace Muse.DAL.Models;

public class RoleTranslation : BaseTranslationEntity
{
    public long RoleId { get; set; }
    public string Name { get; set; } = default!;

    public Role? Role { get; set; }
}