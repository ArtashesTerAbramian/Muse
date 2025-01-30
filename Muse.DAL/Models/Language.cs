namespace Muse.DAL.Models;

public class Language : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Code { get; set; } = default!;
    public bool IsDefault { get; set; }
    public bool IsActive { get; set; }
    public string? PhotoName { get; set; }
    public string? Link { get; set; }
}