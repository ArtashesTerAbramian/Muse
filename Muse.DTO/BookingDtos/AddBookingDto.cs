namespace Muse.DTO.BookingDtos;

public record AddBookingDto
{
    public DateTime Date { get; set; }
    public long UserId { get; set; }
    public ServiceWithSpecificationsDto ServiceWithSpecifications { get; set; }
}

public record ServiceWithSpecificationsDto
{
    public long ServiceId { get; set; }
    public List<long> ServiceSpecificationIds { get; set; } 
}