Person person = new Person("Alice");
person.SayHello(); // Outputs "Hello, my name is Alice."
public class Person
{
    public string name;
    public Person(string _name)
    {
        this.name = _name;
    }

    public void SayHello() // Instance method
    {
        Console.WriteLine($"Hello, my name is {this.name}.");
    }
}