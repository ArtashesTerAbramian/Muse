namespace Muse.DAL.Models;

public class BookingStatusTranslation : BaseTranslationEntity
{
    public string Name { get; set; }
    public long StatusId { get; set; }
    public BookingStatus Status { get; set; }
}