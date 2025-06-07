// List of manufacturers
var manufacturers = new List<Manufacturer>
{
    new Manufacturer
    {
        Name = "Tesla",
        Country = "USA"
    },
    new Manufacturer
    {
        Name = "Ford",
        Country = "USA"
    },
// ...
};
// Join lists to get full data
var carWithCountry = cars.Join(manufacturers, car => car.Manufacturer, manufacturer => manufacturer.Name, (car, manufacturer) => new { car, manufacturer.Country });