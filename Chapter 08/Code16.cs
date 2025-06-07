using System.Text.Json.Serialization;

public class Person
{
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    [JsonInclude]
    private string LastName { get; set; }
}