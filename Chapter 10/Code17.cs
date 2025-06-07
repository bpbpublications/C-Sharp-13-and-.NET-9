// Filter cars that are priced above $30,000
var expensiveCars = cars.Where(car => car.Price > 30000).ToList();
foreach (var car in expensiveCars)
{
    Console.WriteLine($"{car.Manufacturer} {car.Model} - ${car.Price}");
}