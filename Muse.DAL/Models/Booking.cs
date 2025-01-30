namespace Muse.DAL.Models;

public class Booking : BaseEntity
{
    public required DateTime Date { get; set; }
    // public required TimeSpan Duration { get; set; }
    public required long UserId { get; set; }
    public required long ServiceId { get; set; }
    public required long ServiceSpecificationId { get; set; }
    public required long StatusId { get; set; }

    public BookingStatus Status { get; set; }
    public User User { get; set; }
    public Service Service { get; set; }
    public ServiceSpecification ServiceSpecification { get; set; }
}