using System.ComponentModel.DataAnnotations;
using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;

namespace MyEfCoreApp.Models;
public class Product
{
    /// <summary>
    /// Gets or sets the product ID.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the product name.
    /// </summary>
    [Required]
    [StringLength(100)]
    [Display(Name = "Products Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the product price.
    /// </summary>
    [Precision(18, 2)]
    [Display(Name = "Products Price")]
    public decimal Price { get; set; }
}