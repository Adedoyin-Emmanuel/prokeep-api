using System.ComponentModel.DataAnnotations;

namespace prokeep.Models.Dto;



public record CreateProductDto(

    [Required, MinLength(1)] string Title,

    [Required][MaxLength(2500)] string Description,

    [Required] int Price,

    [Required] string Manufacturer
);