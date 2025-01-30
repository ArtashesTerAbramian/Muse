using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class UserFilter : BaseFilter<User>
{
    public long? Id { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public List<long>? RoleIds { get; set; }

    public override IQueryable<User> CreateQuery(IQueryable<User> query)
    {
        if (Query is not null)
        {
            return Query;
        }

        if (Id.HasValue)
        {
            query = query.Where(x => x.Id == Id.Value);
        }

        if (!string.IsNullOrWhiteSpace(Name))
        {
            query = query.Where(x => x.Name.ToLower().Replace(" ", "").Contains(Name.ToLower().Replace(" ", "")));
        }
        
        if (!string.IsNullOrWhiteSpace(Phone))
        {
            query = query.Where(x =>
                !string.IsNullOrWhiteSpace(x.Phone) &&
                x.Phone.ToLower().Replace(" ", "").Contains(Phone.ToLower().Replace(" ", "")));
        }

        if (!string.IsNullOrWhiteSpace(Email))
        {
            query = query.Where(x => x.Email.ToLower().Replace(" ", "").Contains(Email.ToLower().Replace(" ", "")));
        }

        if (RoleIds?.Count > 0)
        {
            query = query.Where(x => RoleIds.Contains(x.RoleId));
        }

        return query.OrderBy(x => x.Id);
    }
}