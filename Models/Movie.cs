using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Birthday")]
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }

  
    [Required]
    [StringLength(10, MinimumLength = 10)]
    public string? Number { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Relationship { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(1)]
    [Required]
    public string? Gender { get; set; }
}
