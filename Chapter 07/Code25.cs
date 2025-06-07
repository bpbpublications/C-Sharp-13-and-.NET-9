using System.Text.RegularExpressions;

string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
bool isValid = Regex.IsMatch("example@email.com", pattern);