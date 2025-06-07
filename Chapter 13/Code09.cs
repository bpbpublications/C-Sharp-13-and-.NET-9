using System.ComponentModel.DataAnnotations;

.. .
[Required(ErrorMessage = "Date of Birth is required")]
[DataType(DataType.Date)]
[DateOfBirthValidation]
public DateTime DateOfBirth { get; set; }

[GuardianValidation]
public string GuardianName { get; set; }

[Phone]
[GuardianValidation]
public string GuardianPhoneNumber { get; set; }