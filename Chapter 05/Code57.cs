Person person1 = new Person("Alice");
Person person2 = new Person("Bob");
Person.ShowCount(); // Outputs "The total number of persons is 2."
public class Person
{
    public string name;
    public static int count = 0;
    public Person(string _name)
    {
        this.name = _name;
        count++;
    }

    public static void ShowCount() // Static method
    {
        Console.WriteLine($"The total number of persons is {count}.");
    }
}