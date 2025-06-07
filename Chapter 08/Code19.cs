using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a new Person object.
        Person person = new Person
        {
            Name = "Alice",
            Age = 30
        };
        // Create a new BinaryFormatter instance.
        BinaryFormatter formatter = new BinaryFormatter();
        // Serialize the Person object to a file.
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }

        Console.WriteLine("Serialization complete.");
    }
}