using Microsoft.EntityFrameworkCore;

namespace Muse.DAL;

public class AppDbContextFactory : DesignTimeDbContextFactory<AppDbContext>
{
    private readonly IContextModificatorService _contextModificatorService;

    public AppDbContextFactory()
    {

    }

    public AppDbContextFactory(IContextModificatorService contextModificatorService)
    {
        _contextModificatorService = contextModificatorService;
    }

    protected override AppDbContext CreateNewInstance(DbContextOptions<AppDbContext> options)
    {
        return new AppDbContext(options, _contextModificatorService);
    }
}
