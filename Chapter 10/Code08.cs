// Create an IQueryable for SUVs
var suvCarsQuery = db.Cars.Where(car => car.Type == "SUV");
// Create an IQueryable for Sedans
var sedanCarsQuery = db.Cars.Where(car => car.Type == "Sedan");
// At this point, no query has been executed against the database yet.
// Execution is deferred until you actually enumerate over the IQueryable.
// Execute query and display SUVs
Console.WriteLine("List of SUVs:");
foreach (var suv in suvCarsQuery) // The query gets executed here
{
    Console.WriteLine($"Manufacturer: {suv.Manufacturer}, Model: {suv.Model}, Price: {suv.Price}, Color: {suv.Color}, Year: {suv.YearOfFabrication}");
}

Console.WriteLine();
// Execute query and display Sedans
Console.WriteLine("List of Sedans:");
foreach (var sedan in sedanCarsQuery) // The query gets executed here
{
    Console.WriteLine($"Manufacturer: {sedan.Manufacturer}, Model: {sedan.Model}, Price: {sedan.Price}, Color: {sedan.Color}, Year: {sedan.YearOfFabrication}");
}

Console.WriteLine();