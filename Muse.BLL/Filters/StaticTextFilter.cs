using Muse.DAL.Models;

namespace Muse.BLL.Filters;

public class StaticTextFilter : BaseFilter<StaticText>
{
    public long? Id { get; set; }
    public string? Key { get; set; }
    public string? Name { get; set; }
    public string? Search { get; set; }

    public override IQueryable<StaticText> CreateQuery(IQueryable<StaticText> query)
    {
        if (Query != null)
        {
            return Query;
        }

        if (Id.HasValue)
        {
            query = query.Where(x => x.Id == Id.Value);
        }

        if (!string.IsNullOrEmpty(Key))
        {
            query = query.Where(x => x.Key.ToLower().Replace(" ", "").Contains(Key.ToLower().Replace(" ", "")));
        }

        if (!string.IsNullOrEmpty(Name))
        {
            query = query.Where(x =>
                x.Translations.Any(x => x.Name.ToLower().Replace(" ", "").Contains(Name.ToLower().Replace(" ", ""))));
        }

        if (!string.IsNullOrEmpty(Search))
        {
            query = query.Where(x => x.Translations.Any(x =>
                                         x.Name.ToLower().Replace(" ", "")
                                             .Contains(Search.ToLower().Replace(" ", ""))));
        }

        return query.OrderByDescending(x => x.Id);
    }
}