using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using prokeep.Controllers.Extensions;


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
            Title = "Chocolate Bread",
            Description = "Sweet yummy chocolate bread"
        };


        return new CreatedAtActionResult("Create", "Product", response, new Respond("Product created successfully", response));

    }

}