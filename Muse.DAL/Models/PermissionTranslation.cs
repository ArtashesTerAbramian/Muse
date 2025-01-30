namespace Muse.DAL.Models;

public class PermissionTranslation : BaseTranslationEntity
{
    public long PermissionId { get; set; }
    public string Name { get; set; } = default!;


    public Permission? Permission { get; set; }
}