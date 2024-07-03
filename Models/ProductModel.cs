using System.ComponentModel.DataAnnotations.Schema;



namespace prokeep.Models;


public class Product
{

    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public int Price { get; set; }
    public required string Manufacturer { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }
}