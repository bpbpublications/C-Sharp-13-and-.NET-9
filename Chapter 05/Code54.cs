Person person1 = new Person("Alice");
Person person2 = new Person("Bob");
Console.WriteLine(person1.name); // Outputs "Alice"
Console.WriteLine(person2.name); // Outputs "Bob"
public class Person
{
    public string name; // Instance member
    public Person(string _name)
    {
        this.name = _name;
    }
}