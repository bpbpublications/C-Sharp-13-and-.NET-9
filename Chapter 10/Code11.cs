using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

var carsToSeed = new List<Car>
{
    new Car
    {
        Manufacturer = "Tesla",
        Model = "Model S",
        Price = 80000,
        Color = "Red",
        Type = "Sedan",
        YearOfFabrication = 2023
    },
    new Car
    {
        Manufacturer = "Ford",
        Model = "Focus",
        Price = 20000,
        Color = "Blue",
        Type = "Hatchback",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Honda",
        Model = "Civic",
        Price = 22000,
        Color = "Black",
        Type = "Sedan",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Toyota",
        Model = "Camry",
        Price = 24000,
        Color = "White",
        Type = "Sedan",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Nissan",
        Model = "Altima",
        Price = 23000,
        Color = "Silver",
        Type = "Sedan",
        YearOfFabrication = 2020
    },
    new Car
    {
        Manufacturer = "Chevrolet",
        Model = "Malibu",
        Price = 22000,
        Color = "Grey",
        Type = "Sedan",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Volkswagen",
        Model = "Passat",
        Price = 26000,
        Color = "Blue",
        Type = "Sedan",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Subaru",
        Model = "Outback",
        Price = 27000,
        Color = "Green",
        Type = "SUV",
        YearOfFabrication = 2023
    },
    new Car
    {
        Manufacturer = "Hyundai",
        Model = "Elantra",
        Price = 20000,
        Color = "Red",
        Type = "Sedan",
        YearOfFabrication = 2020
    },
    new Car
    {
        Manufacturer = "Kia",
        Model = "Sorento",
        Price = 29000,
        Color = "Black",
        Type = "SUV",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Jeep",
        Model = "Cherokee",
        Price = 34000,
        Color = "Brown",
        Type = "SUV",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Mazda",
        Model = "3",
        Price = 21000,
        Color = "Red",
        Type = "Hatchback",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Audi",
        Model = "A4",
        Price = 40000,
        Color = "White",
        Type = "Sedan",
        YearOfFabrication = 2023
    },
    new Car
    {
        Manufacturer = "Mercedes-Benz",
        Model = "C-Class",
        Price = 42000,
        Color = "Black",
        Type = "Sedan",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "BMW",
        Model = "3 Series",
        Price = 41000,
        Color = "Blue",
        Type = "Sedan",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Land Rover",
        Model = "Discovery",
        Price = 52000,
        Color = "Green",
        Type = "SUV",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Porsche",
        Model = "Macan",
        Price = 60000,
        Color = "Grey",
        Type = "SUV",
        YearOfFabrication = 2023
    },
    new Car
    {
        Manufacturer = "Lexus",
        Model = "ES",
        Price = 39000,
        Color = "Silver",
        Type = "Sedan",
        YearOfFabrication = 2021
    },
    new Car
    {
        Manufacturer = "Volvo",
        Model = "S60",
        Price = 37000,
        Color = "Blue",
        Type = "Sedan",
        YearOfFabrication = 2022
    },
    new Car
    {
        Manufacturer = "Cadillac",
        Model = "CTS",
        Price = 45000,
        Color = "Black",
        Type = "Sedan",
        YearOfFabrication = 2023
    }
};
var carsToXML = new XElement("Cars", from car in carsToSeed
    select new XElement("Car", new XElement("Manufacturer", car.Manufacturer), new XElement("Model", car.Model), new XElement("Price", car.Price), new XElement("Color", car.Color), new XElement("Type", car.Type), new XElement("YearOfFabrication", car.YearOfFabrication)));
carsToXML.Save("Cars.xml");
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