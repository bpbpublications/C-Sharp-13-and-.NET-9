List<Person> people = [new("Steve", "Jobs"), new("Steve", "Carell"), new("Elon", "Musk")];
foreach (var peopleWithSameFirstName in people.CountBy(p => p.FirstName))
{
    Console.WriteLine($"There are {peopleWithSameFirstName.Value} people with the name {peopleWithSameFirstName.Key}");
}

public record Person(string FirstName, string LastName);