using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Muse.BLL.Services.ContextModificatorService;
using Muse.BLL.Services.ErrorService;
using Muse.DAL;

namespace Muse.BLL;
public static class ServiceExtension 
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IContextModificatorService, ContextModificatorService>();
        services.AddScoped<IErrorService, ErrorService>();

        return services;
    }
}
