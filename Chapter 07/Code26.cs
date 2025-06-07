using System.Text.RegularExpressions;

string pattern = @"https?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
MatchCollection matches = Regex.Matches("Visit https://www.example.com for more info.", pattern);