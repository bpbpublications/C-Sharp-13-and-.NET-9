using System;
using System.ComponentModel.DataAnnotations;

namespace MyNameSpace.Data;
public class Employee
{
    public DateTime Date { get; set; }
    public int EmployeeId { get; set; }

    [Required]
    [MinLength(2)]
    public int FirstName { get; set; }
    public string Email { get; set; }
}