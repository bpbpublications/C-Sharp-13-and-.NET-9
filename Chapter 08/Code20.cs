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
        // Create a new BinaryFormatter instance.
        BinaryFormatter formatter = new BinaryFormatter();
        // Deserialize the Person object from a file.
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person person = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}