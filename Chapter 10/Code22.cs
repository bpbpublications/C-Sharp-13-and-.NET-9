// The query doesn’t execute here
var query = cars.Where(car => car.Price < 30000).OrderBy(car => car.Price).Select(car => new { car.Manufacturer, car.Model });
// The query executes when you enumerate the results
foreach (var car in query)
{
    Console.WriteLine($"{car.Manufacturer} {car.Model}");
}