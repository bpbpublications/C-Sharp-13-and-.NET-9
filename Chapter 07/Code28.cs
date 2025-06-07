using System.Text.RegularExpressions;

string[] result = Regex.Split("apple,orange;banana:grape", "[,;:]");// result: ["apple", "orange", "banana", "grape"]
