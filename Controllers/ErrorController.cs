using System.Net;
using Microsoft.AspNetCore.Mvc;
using prokeep.Controllers.Extensions;


namespace prokeep.Controllers;


[Route("/error")]
[ApiController]


public class ErrorController : ControllerBase
{

    [Route("{code}")]
    [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
    public IActionResult Error(int code)
    {
        HttpStatusCode parsedCode = (HttpStatusCode)code;
        ApiError error = new(code, parsedCode.ToString());

        return new JsonResult(error);

    }
}
