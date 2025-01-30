using Ardalis.Result;
using Muse.DAL;
using Muse.DTO;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Mappers;

namespace Muse.BLL.Services.ErrorService;

public class ErrorService : IErrorService
{
    private readonly AppDbContext _db;

    public ErrorService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<Result<ErrorModelDto>> GetById(long id)
    {
        var error = await _db.Errors
            .Include(x => x.Translations.OrderByDescending(x => x.LanguageId))
            .FirstOrDefaultAsync(x => x.Id == id);

        if (error == null)
        {
            return Result.NotFound();
        }

        return error.MapToDto();

        // return new ErrorModelDto()
        // {
        //     Code = error.Id,
        //     Description = error.Name
        // };
    }

    public async Task<string> GetErrorName(long id)
    {
        await _db.ErrorTranslations.Where(x => x.ErrorId == id)
            .OrderByDescending(x => x.LanguageId).ToListAsync();

        var errorName = await _db.Errors.Where(x => x.Id == id)
            .SelectMany(x => x.Translations)
            .OrderByDescending(x => x.LanguageId)
            .Select(t => t.Name)
            .FirstOrDefaultAsync();

        if (errorName == null)
        {
            return "Error not found";
        }

        return errorName;
    }
}