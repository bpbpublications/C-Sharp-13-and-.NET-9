List<Person> people = new()
{
    new("Steve", "Jobs", 10),
    new("Steve", "Carell", 100),
    new("Elon", "Musk", 10)
};
var aggregateBy = people.AggregateBy(person => person.SomeNumber, // Group by SomeNumber
 x => 0, // Start each aggregation with 0
 (x, y) => x + y.SomeNumber // Add each person's SomeNumber to the sum
);
foreach (var kvp in aggregateBy)
{
    Console.WriteLine($"Sum of SomeNumber for Key {kvp.Key} is {kvp.Value}");
}

public record Person(string FirstName, string LastName, int SomeNumber);