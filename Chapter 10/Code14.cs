using System.Text.Json;

var carParts = new List<CarPart>
{
    new CarPart
    {
        PartName = "Engine",
        PartNumber = "ENG-001",
        Manufacturer = "Ford",
        Price = 5000
    },
    new CarPart
    {
        PartName = "Transmission",
        PartNumber = "TRN-002",
        Manufacturer = "Toyota",
        Price = 2000
    },
    new CarPart
    {
        PartName = "Brake Pad",
        PartNumber = "BRK-003",
        Manufacturer = "Honda",
        Price = 200
    }
};
string jsonString = JsonSerializer.Serialize(carParts);
File.WriteAllText("CarParts.json", jsonString);
public class CarPart
{
    public string PartName { get; set; }
    public string PartNumber { get; set; }
    public string Manufacturer { get; set; }
    public int Price { get; set; }
}