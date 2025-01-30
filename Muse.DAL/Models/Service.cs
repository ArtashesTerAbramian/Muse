namespace Muse.DAL.Models;

public class Service : BaseEntity
{
    public Service()
    {
        Translations = new HashSet<ServiceTranslation>();
        Bookings = new HashSet<Booking>();
        ServiceSpecifications = new HashSet<ServiceSpecification>();
    }

    public ICollection<ServiceSpecification> ServiceSpecifications { get; set; }
    public ICollection<ServiceTranslation> Translations { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}