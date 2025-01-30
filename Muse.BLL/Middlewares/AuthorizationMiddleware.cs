using Ardalis.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Muse.BLL.Attributes;
using Muse.BLL.Constants;
using Muse.BLL.Services.ErrorService;
using Muse.BLL.Services.UserService;

namespace Muse.BLL.Middlewares;

public class AuthorizationMiddleware
{
    private readonly RequestDelegate _next;

    public AuthorizationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (!SkipPermissionCheck(context))
        {
            var userSessionService = context.RequestServices.GetRequiredService<IUserSessionService>();

            if (!await userSessionService.HasPermission(context.Request.Path))
            {
                var errorService = context.RequestServices.GetRequiredService<IErrorService>();

                context.Response.StatusCode = StatusCodes.Status403Forbidden;

                await context.Response.WriteAsJsonAsync(
                    Result.Error(await errorService.GetErrorName(ErrorConstants.AccessDenied)));

                return;
            }
        }

        await _next(context);
    }

    private bool SkipPermissionCheck(HttpContext context)
    {
        var endpoint = context.GetEndpoint();

        if (endpoint == null)
        {
            return false;
        }

        var controllerActionDescriptor = endpoint.Metadata.GetMetadata<ControllerActionDescriptor>();

        if (controllerActionDescriptor == null)
        {
            return false;
        }

        var controllerHasAttribute = controllerActionDescriptor.ControllerTypeInfo.GetCustomAttributes(true)
            .Any(attr => attr.GetType() == typeof(SkipPermissionCheckAttribute));

        if (controllerHasAttribute)
        {
            return true;
        }

        var actionHasAttribute = controllerActionDescriptor.MethodInfo.GetCustomAttributes(true)
            .Any(attr => attr.GetType() == typeof(SkipPermissionCheckAttribute));

        return actionHasAttribute;
    }
}