using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    //https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt#column-data-types
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }
    
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")] //currency
    public decimal Price { get; set; }

}