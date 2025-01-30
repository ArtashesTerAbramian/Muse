using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Muse.BLL.Enums;
using Muse.BLL.Services.UserService;
using Muse.DAL;

namespace Muse.BLL.Middlewares;

public class LanguageMiddleware : IMiddleware
{
    private readonly AppDbContext _db;

    public LanguageMiddleware(AppDbContext db)
    {
        _db = db;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var languageService = context.RequestServices.GetRequiredService<ILanguageService>();

        var userSessionService = context.RequestServices.GetRequiredService<IUserSessionService>();
        
        languageService.LanguageId = (int)LanguageEnum.English;

        var acceptLanguage = context.Request.Headers["Lang-Code"].ToString();

        if (!string.IsNullOrWhiteSpace(acceptLanguage))
        {
            switch (acceptLanguage)
            {
                case "en":
                    languageService.LanguageId = (int)LanguageEnum.English;
                    break;
                case "ru":
                    languageService.LanguageId = (int)LanguageEnum.Russian;
                    break;
                case "am":
                    languageService.LanguageId = (int)LanguageEnum.Armenian;
                    break;
            }
        }

        if (userSessionService.CurrentUser is not null)
        {
            languageService.LanguageId = ((await _db.Users
                .Where(x => x.Id == userSessionService.CurrentUser.Id)?
                .FirstOrDefaultAsync()!)!).DefaultLanguageId;
        }


        await next(context);
    }
}

public static class LanguageMiddlewareExtension
{
    public static WebApplication UseLanguageMiddleware(this WebApplication app)
    {
        app.UseMiddleware<LanguageMiddleware>();

        return app;
    }
}