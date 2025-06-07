using System.ComponentModel.DataAnnotations;

public class DateOfBirthValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime dob = (DateTime)value;
        if (dob < DateTime.Now && dob > new DateTime(1900, 1, 1))
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("Invalid Date of Birth. Date must be older than today and after 01/01/1900.");
        }
    }
}