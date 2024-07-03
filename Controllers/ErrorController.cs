using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using prokeep.Controllers.Extensions;


namespace prokeep.Controller
{


    [Route("/error")]
    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("{code}")]
        public IActionResult Error(int code)
        {
            HttpStatusCode parsedCode = (HttpStatusCode)code;
            ApiError error = new(code, parsedCode.ToString());

            return new JsonResult(error);

        }
    }
}