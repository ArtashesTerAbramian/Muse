using Ardalis.Result;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Mappers;
using Muse.DAL;
using Muse.DTO.ServiceDtos;

namespace Muse.BLL.Services.ServiceService;

public class ServiceService : IServiceService
{
    private readonly AppDbContext _db;

    public ServiceService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<Result<ServiceDto>> GetById(long id)
    {
        var service = await _db.Services.Include(x => x.Translations).FirstOrDefaultAsync(x => x.Id == id);

        if (service is null)
        {
            return Result.NotFound();
        }

        return service.MapToDto();
    }

    public async Task<PagedResult<List<ServiceDto>>> GetAllAsync()
    {
        var services = await _db.Services.Include(x => x.Translations).ToListAsync();

        return new PagedResult<List<ServiceDto>>(new PagedInfo(1, 1, 1, 1), services.MapToDto());
    }
}