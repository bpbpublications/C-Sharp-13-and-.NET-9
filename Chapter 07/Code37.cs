// Creating a tuple with three elements
Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "Hello", true);
// Accessing elements
Console.WriteLine(tuple.Item1); // Outputs: 1
Console.WriteLine(tuple.Item2); // Outputs: Hello
Console.WriteLine(tuple.Item3); // Outputs: True
// Creating a ValueTuple with named elements
(int Id, string Name, bool IsActive) person = (1, "John", true);
// Accessing elements by their names
Console.WriteLine(person.Id); // Outputs: 1
Console.WriteLine(person.Name); // Outputs: John
Console.WriteLine(person.IsActive); // Outputs: True
