using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace prokeep.Controllers;


[ApiController]
[Route("api/[Controller]")]
public class ProductController : ControllerBase
{


    [HttpPost]

    public async Task<IActionResult> Create()
    {
        var response = new
        {
            Title = "Created",
            Message = "Item created successfully"
        };

        return new JsonResult(new { title = "created", message = "Item created successfully" })
        {
            StatusCode = 201,
        };
    }

}