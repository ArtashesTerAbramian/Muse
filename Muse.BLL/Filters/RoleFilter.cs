using Muse.BLL.Enums;
using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class RoleFilter : BaseFilter<Role>
{
    public long? Id { get; set; }
    public string? Name { get; set; }

    public override IQueryable<Role> CreateQuery(IQueryable<Role> query)
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

        return query.Where(x => x.Id != (long)UserRoleEnum.Admin).OrderByDescending(x => x.Id);
    }
}