using Muse.DAL;

namespace Muse.BLL.Services.ContextModificatorService;

public class ContextModificatorService : IContextModificatorService
{
    public bool IsGlobalQueryFiltersEnable { get; } = true;
}