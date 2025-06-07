// Group cars by manufacturer
var carsGroupedByManufacturer = cars.GroupBy(car => car.Manufacturer);
foreach (var group in carsGroupedByManufacturer)
{
    Console.WriteLine($"Manufacturer: {group.Key}");
    foreach (var car in group)
    {
        Console.WriteLine($"    Model: {car.Model}, Price: ${car.Price}");
    }
}