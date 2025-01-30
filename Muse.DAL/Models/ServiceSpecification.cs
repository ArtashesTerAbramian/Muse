namespace Muse.DAL.Models;

public class ServiceSpecification : BaseEntity
{
    public ServiceSpecification()
    {
        Translation = new HashSet<ServiceSpecificationTranslation>();
        Bookings = new HashSet<Booking>();
    }

    public TimeSpan Duration { get; set; }
    public long ServiceId { get; set; }
    public Service Service { get; set; }
    public ICollection<ServiceSpecificationTranslation> Translation { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}