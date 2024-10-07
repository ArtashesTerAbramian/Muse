using Microsoft.AspNetCore.Mvc;

namespace Muse.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    public ApiControllerBase()
    {

    }
}
