using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace prokeep.Models.Dto;



public record UpdateProductDto(

    [Optional, MaxLength(20)] string Title,

    [Optional][MaxLength(2500)] string Description,

    [Optional] int Price,

    [Optional] string Manufacturer
);