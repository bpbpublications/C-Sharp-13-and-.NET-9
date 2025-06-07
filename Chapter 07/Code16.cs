var emailPattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
var emails = new[]
{
    "test@example.com",
    "invalid-email@",
    "sample@domain.org"
};
foreach (var email in emails)
{
    Console.WriteLine($"{email} is {(Regex.IsMatch(email, emailPattern) ? "valid" : "invalid")}");
}