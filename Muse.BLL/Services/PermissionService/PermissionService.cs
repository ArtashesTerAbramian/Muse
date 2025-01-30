using Ardalis.Result;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Filters;
using Muse.BLL.Mappers;
using Muse.BLL.Services.ErrorService;
using Muse.DAL;
using Muse.DTO.PermissionDtos;

namespace Muse.BLL.Services.PermissionService;

public class PermissionService : IPermissionService
{
    private readonly AppDbContext _db;
    private readonly IErrorService _errorService;

    public PermissionService(AppDbContext db, IErrorService errorService)
    {
        _db = db;
        _errorService = errorService;
    }

    public async Task<Result<PermissionDto>> GetById(long id)
    {
        var staticText = await _db.Permissions
            // .IgnoreQueryFilters().ApplyFilters(_userConfigurationService)
            .Include(x => x.Translations.OrderByDescending(x => x.LanguageId))
            .FirstOrDefaultAsync(x => x.Id == id);

        if (staticText is null)
        {
            return Result.NotFound();
        }

        return staticText.MapToDto();
    }

    public async Task<PagedResult<List<PermissionDto>>> GetAll(PermissionFilter filter)
    {
        var query = _db.Permissions
            .Include(x => x.Translations.OrderByDescending(x => x.LanguageId))
            .AsQueryable();

        var entities = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<PermissionDto>>(await filter.GetPagedInfoAsync(query), entities.MapToDto());
    }
}