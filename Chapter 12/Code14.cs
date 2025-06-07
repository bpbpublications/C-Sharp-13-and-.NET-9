using System.ComponentModel.DataAnnotations;

public class AgeValidationAttribute : ValidationAttribute
{
    public int MinimumAge { get; }

    public AgeValidationAttribute(int minimumAge)
    {
        MinimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateOfBirth)
        {
            var age = DateTime.Today.Year - dateOfBirth.Year;
            if (age >= MinimumAge)
                return ValidationResult.Success;
        }

        return new ValidationResult($"You must be at least {MinimumAge} years old.");
    }
}