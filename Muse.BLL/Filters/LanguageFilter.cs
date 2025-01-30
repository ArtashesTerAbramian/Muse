using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class LanguageFilter : BaseFilter<Language>
{
    public long? Id { get; set; }
    public string? Name { get; set; }
    public bool? IsActive { get; set; }

    public override IQueryable<Language> CreateQuery(IQueryable<Language> query)
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

        if (IsActive.HasValue)
        {
            query = query.Where(x => x.IsActive == IsActive.Value);
        }

        return query.OrderByDescending(x => x.Id);
    }
}