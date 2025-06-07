using System.Text.RegularExpressions;

string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|1\d|2\d|3[01])/\d{4}$";
bool isValidDate = Regex.IsMatch("08/11/2023", pattern);