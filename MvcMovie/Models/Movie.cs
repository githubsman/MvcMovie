using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    //https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt#column-data-types
    //https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-8.0#using-datatype-attributes
    public int Id { get; set; }

    [Required, StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }

    [DataType(DataType.Date)]   //  specifies the data type as (Date); prevents time from displaying
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Required, RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(30)] 
    public string? Genre { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]   //currency
    public decimal Price { get; set; }

    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
    public string? Rating { get; set; }
}