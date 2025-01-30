namespace Muse.DAL.Models;

public class BookingStatus : BaseEntity
{
    public BookingStatus()
    {
        Translations = new HashSet<BookingStatusTranslation>();
    }

    public ICollection<BookingStatusTranslation> Translations { get; set; }
}