var whitespacePattern = @"\s+";
var spacedText = "This    has   irregular     spaces.";
var cleanedText = Regex.Replace(spacedText, whitespacePattern, " ");
Console.WriteLine($"Original: {spacedText}");
Console.WriteLine($"Cleaned: {cleanedText}");