using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

string xmlFilePath = "Cars.xml"; // Assuming the file is in the same directory as the executable
XDocument xDocument = XDocument.Load(xmlFilePath);
var carsFromXml = xDocument.Descendants("Car").Select(car => new Car { Manufacturer = car.Element("Manufacturer")?.Value, Model = car.Element("Model")?.Value, Price = double.Parse(car.Element("Price")?.Value ?? "0"), Color = car.Element("Color")?.Value, Type = car.Element("Type")?.Value, YearOfFabrication = int.Parse(car.Element("YearOfFabrication")?.Value ?? "0") }).ToList();
// Display the cars read from the XML file
foreach (var car in carsFromXml)
{
    Console.WriteLine($"Manufacturer: {car.Manufacturer}, Model: {car.Model}, Price: {car.Price}, Color: {car.Color}, Type: {car.Type}, Year Of Fabrication: {car.YearOfFabrication}");
}

public class Car
{
    [Key]
    public int Id { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
    public string Type { get; set; } // Sedan, SUV, etc.
    public int YearOfFabrication { get; set; }
}