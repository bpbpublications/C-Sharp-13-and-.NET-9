Employee employee = new Employee("John Doe", "Developer");
Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}");
// Outputs: Name: John Doe, Position: Developer
public class Person
{
    public string Name { get; }

    // Base class constructor
    public Person(string name)
    {
        Name = name;
    }
}

public class Employee : Person
{
    public string Position { get; }

    // Derived class constructor
    public Employee(string name, string position) : base(name) // Using base keyword
    {
        Position = position;
    }
}