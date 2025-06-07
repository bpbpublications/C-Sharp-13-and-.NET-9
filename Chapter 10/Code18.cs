// Select only the models of the cars
var carModels = cars.Select(car => car.Model).ToList();
foreach (var model in carModels)
{
    Console.WriteLine(model);
}