public class Employee
{
    [EmailDomainValidator(AllowedDomain = "pragimtech.com")]
    public string Email { get; set; }
}