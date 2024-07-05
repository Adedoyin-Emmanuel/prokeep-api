using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prokeep.Controllers.Extensions;
using prokeep.Models;
using prokeep.Models.Dto;


namespace prokeep.Controllers;


[Route("api/[controller]")]
[ApiController]

public class ProductController(ILogger<ProductController> logger, AppContext dbContext) : ControllerBase
{

    private readonly ILogger<ProductController> _logger = logger;
    private readonly AppContext _dbContext = dbContext;



    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto createProductDto)
    {
        var product = new Product
        {
            Title = createProductDto.Title,
            Description = createProductDto.Description,
            Price = createProductDto.Price,
            Manufacturer = createProductDto.Manufacturer
        };

        await _dbContext.Product.AddAsync(product);

        await _dbContext.SaveChangesAsync();

        return new CreatedAtActionResult("Create", "Product", product, new Respond("Product created successfully", product));

    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _dbContext.Product.ToListAsync();

        return Ok(new Respond("Products fetched successfully", products));
    }



    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _dbContext.Product.FindAsync(id);

        if (product is null) return NotFound(new Respond("Product not found", 404));

        return Ok(new Respond("Product fetched successfully", product));
    }



    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Update(Guid id)
    {
        return Ok();
    }

}