using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Muse.BLL.Helpers;
using Muse.BLL.Middlewares;
using Muse.BLL.Models;
using Muse.BLL.Services.ContextModificatorService;
using Muse.BLL.Services.ErrorService;
using Muse.BLL.Services.LanguageService;
using Muse.BLL.Services.MailService;
using Muse.BLL.Services.PermissionService;
using Muse.BLL.Services.RoleService;
using Muse.BLL.Services.ServiceService;
using Muse.BLL.Services.UserService;
using Muse.DAL;

namespace Muse.BLL;

public static class ServiceExtension
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MailServiceOptions>(options =>
            configuration.GetSection(nameof(MailServiceOptions)).Bind(options));
        services.Configure<FileSettings>(options => configuration.GetSection(nameof(FileSettings)).Bind(options));
        services.Configure<AuthOptions>(options => configuration.GetSection(nameof(AuthOptions)).Bind(options));
        services.Configure<LinkOptions>(options => configuration.GetSection(nameof(LinkOptions)).Bind(options));

        services.AddSingleton<FileHelper>();
        services.AddScoped<LanguageMiddleware>();
        services.AddSingleton<IMailService, MailService>();

        services.AddScoped<IErrorService, ErrorService>();
        services.AddScoped<IContextModificatorService, ContextModificatorService>();
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<IUserSessionService, UserSessionService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPermissionService, PermissionService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IMailSenderService, MailSenderService>();
        services.AddScoped<IServiceService, ServiceService>();
        

        return services;
    }
}