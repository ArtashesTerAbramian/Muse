using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class BookingFilter : BaseFilter<Booking>
{
    public long UserId { get; set; }
    public long? StatusId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public override IQueryable<Booking> CreateQuery(IQueryable<Booking> query)
    {
        if (Query is not null)
        {
            return Query;
        }

        query = query.Where(x => x.UserId == UserId);

        if (StatusId.HasValue)
        {
            query = query.Where(x => x.StatusId == StatusId);
        }

        if (StartDate.HasValue)
        {
            query = query.Where(x => x.Date >= StartDate);
        }

        if (EndDate.HasValue)
        {
            query = query.Where(x => x.Date <= EndDate);
        }

        return query.OrderByDescending(x => x.Date);
    }
}