using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using CarContext db = new CarContext();
// Create the database
db.Database.EnsureCreated();
// Seed database
if (!db.Cars.Any())
{
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
        }, …
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
    db.Cars.AddRange(carsToSeed);
    db.SaveChanges();
}

// Display cars sorted by Manufacturer
var carsByManufacturer = db.Cars.OrderBy(c => c.Manufacturer);
Console.WriteLine("Cars sorted by Manufacturer:");
foreach (var car in carsByManufacturer)
{
    Console.WriteLine($"Manufacturer: {car.Manufacturer}, Model: {car.Model}, Price: {car.Price}, Color: {car.Color}, Type: {car.Type}, Year: {car.YearOfFabrication}");
}

Console.WriteLine();
// Display cars sorted by Type
var carsByType = db.Cars.OrderBy(c => c.Type);
Console.WriteLine("Cars sorted by Type:");
foreach (var car in carsByType)
{
    Console.WriteLine($"Manufacturer: {car.Manufacturer}, Model: {car.Model}, Price: {car.Price}, Color: {car.Color}, Type: {car.Type}, Year: {car.YearOfFabrication}");
}

Console.WriteLine();
// Summarize price and count by Manufacturer and Model
var summary = db.Cars.GroupBy(c => new { c.Manufacturer, c.Model }).Select(g => new { g.Key.Manufacturer, g.Key.Model, Count = g.Count(), TotalPrice = g.Sum(c => c.Price) });
Console.WriteLine("Summary:");
foreach (var item in summary)
{
    Console.WriteLine($"Manufacturer: {item.Manufacturer}, Model: {item.Model}, Count: {item.Count}, Total Price: {item.TotalPrice}");
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

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarResellerDB;Trusted_Connection=True;");
    }
}