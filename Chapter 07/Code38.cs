var person = GetPerson();
Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
(string, int) GetPerson()
{
    return ("Alice", 30);
}