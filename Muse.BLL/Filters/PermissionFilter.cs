using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class PermissionFilter : BaseFilter<Permission>
{
    public long? Id { get; set; }

    public string? Name { get; set; }
    public string? Value { get; set; }

    public override IQueryable<Permission> CreateQuery(IQueryable<Permission> query)
    {
        if (Query is not null)
        {
            return Query;
        }

        if (Id.HasValue)
        {
            query = query.Where(x => x.Id == Id.Value);
        }

        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(x =>
                x.Translations.Any(x => x.Name.ToLower().Replace(" ", "").Contains(Name.ToLower().Replace(" ", ""))));
        }

        if (!string.IsNullOrWhiteSpace(Value))
        {
            query = query.Where(x => x.Value.ToLower().Replace(" ", "").Contains(Value.ToLower().Replace(" ", "")));
        }

        return query.OrderByDescending(x => x.Id);
    }
}