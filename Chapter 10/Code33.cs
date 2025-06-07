List<string> names = new List<string>
{
    "Alice",
    "Bob",
    "ALICE",
    "Charlie",
    "bob"
};
var uniqueNames = names.Distinct(new CaseInsensitiveComparer()).ToList();
foreach (var name in uniqueNames)
{
    Console.WriteLine(name);
}

class CaseInsensitiveComparer : IEqualityComparer<string>
{
    public bool Equals(string x, string y)
    {
        return x.Equals(y, StringComparison.OrdinalIgnoreCase);
    }

    public int GetHashCode(string obj)
    {
        return obj.ToLowerInvariant().GetHashCode();
    }
}