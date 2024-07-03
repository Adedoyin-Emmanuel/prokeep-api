using System.ComponentModel.DataAnnotations;


namespace prokeep.Models.Dto;



public class CreateProductDto
{

    [Required]
    [MaxLength(50)]
    public required string Title { get; set; }

    [Required]
    [MaxLength(2500)]
    public required string Description { get; set; }


    [Required]
    public required int Price { get; set; }

    [Required]
    public required string Manufacturer { get; set; }
}