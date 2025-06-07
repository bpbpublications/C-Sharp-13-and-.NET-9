var numberPattern = @"\d+";
var textWithNumbers = "I have 5 apples and 10 oranges.";
var matches = Regex.Matches(textWithNumbers, numberPattern);
Console.WriteLine("Numbers extracted:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}