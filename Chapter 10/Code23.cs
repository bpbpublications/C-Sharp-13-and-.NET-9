var complexFilter = cars.Where(car => (car.YearOfFabrication >= 2021) && (car.Manufacturer == "Tesla" || car.Price < 30000)).ToList();
foreach (var car in complexFilter)
{
    Console.WriteLine($"{car.Manufacturer} {car.Model} - ${car.Price}");
}