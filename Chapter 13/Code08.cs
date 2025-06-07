using System.ComponentModel.DataAnnotations;

public class GuardianValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var emergencyFormModel = (EmergencyModel)validationContext.ObjectInstance;
        DateTime dob = emergencyFormModel.DateOfBirth;
        var age = DateTime.Now.Year - dob.Year;
        if (dob > DateTime.Now.AddYears(-age))
            age--;
        // Check if the age is less than 18
        if (age < 18)
        {
            // Retrieve the GuardianName and GuardianPhoneNumber from the model
            if (string.IsNullOrWhiteSpace(emergencyFormModel.GuardianName) || string.IsNullOrWhiteSpace(emergencyFormModel.GuardianPhoneNumber))
            {
                return new ValidationResult("Guardian name and phone number are required for patients under 18 years of age.");
            }
        }

        // If the age is 18 or above, or if guardian details are provided for minors, validation is successful
        return ValidationResult.Success;
    }
}