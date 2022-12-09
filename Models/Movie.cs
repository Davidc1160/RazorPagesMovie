using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }
    [Display(Name = "Recipe Name")]
    public string Title { get; set; } = string.Empty;
    

    [Display(Name = "Date Created")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Ingredients")]
    public string Genre { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Cost")]
    public decimal Price { get; set; }
}