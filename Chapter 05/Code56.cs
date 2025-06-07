Person person1 = new Person("Alice");
Person person2 = new Person("Bob");
Console.WriteLine(Person.count); // Outputs "2"
public class Person
{
    public string name;
    public static int count = 0; //Static member
    public Person(string _name)
    {
        this.name = _name;
        count++;
    }
}