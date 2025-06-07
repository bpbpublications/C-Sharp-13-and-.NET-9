using Microsoft.AspNetCore.SignalR;
using System.Text.Json.Serialization;

public class MyHub : Hub
{
    public void Method(JsonPerson person)
    {
        if (person is JsonPersonExtended)
        {
        // Handle JsonPersonExtended
        }
        else if (person is JsonPersonExtended2)
        {
        // Handle JsonPersonExtended2
        }
        else
        {
        // Handle base JsonPerson
        }
    }
}

[JsonPolymorphic]
// Here we define the other types we like
[JsonDerivedType(typeof(JsonPersonExtended), nameof(JsonPersonExtended))]
[JsonDerivedType(typeof(JsonPersonExtended2), nameof(JsonPersonExtended2))]
public class JsonPerson
{
    public string Name { get; set; }
    public Person Child { get; set; }
    public Person Parent { get; set; }
}

public class JsonPersonExtended : JsonPerson
{
    public int Age { get; set; }
}

public class JsonPersonExtended2 : JsonPerson
{
    public string Location { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }
}