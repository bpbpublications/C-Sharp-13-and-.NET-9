List<string> names = new List<string>
{
    "Alice",
    "Bob",
    "Charlie",
    "David"
};
var upperCaseNames = names.Select(name => name.ToUpper());
foreach (string name in upperCaseNames)
{
    Console.WriteLine(name);
}