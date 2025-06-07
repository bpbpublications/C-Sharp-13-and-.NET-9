using System.Text.Json;

string jsonString = File.ReadAllText("CarParts.json");
List<CarPart> carParts = JsonSerializer.Deserialize<List<CarPart>>(jsonString);
foreach (var part in carParts)
{
    Console.WriteLine($"Part Name: {part.PartName}, Manufacturer: {part.Manufacturer}");
}