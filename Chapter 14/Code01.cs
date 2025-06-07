using System.ComponentModel.DataAnnotations;

namespace MyEfCoreApp.Models;
public class Nursery
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name length can't be more than 100 characters.")]
    [Display(Name = "Nursery Name")]
    public string Name { get; set; }

    [Range(1, 100, ErrorMessage = "Capacity must be between 1 and 100.")]
    [Display(Name = "Maximum Capacity")]
    public int Capacity { get; set; }

    [Required]
    [Display(Name = "Available Facilities")]
    public string Facilities { get; set; }
}