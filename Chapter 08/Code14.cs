using System;
using System.IO;
using System.Xml.Serialization;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person
        {
            Name = "Alice",
            Age = 30
        };
        // Serialize object to XML
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (StringWriter writer = new StringWriter())
        {
            serializer.Serialize(writer, person);
            string xmlString = writer.ToString();
            Console.WriteLine("Serialized XML:");
            Console.WriteLine(xmlString);
        }

        // Deserialize object from XML
        string xmlInput = "<Person><Name>Alice</Name><Age>30</Age></Person>";
        using (StringReader reader = new StringReader(xmlInput))
        {
            Person deserializedPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Deserialized Person: Name = {deserializedPerson.Name}, Age = {deserializedPerson.Age}");
        }
    }
}