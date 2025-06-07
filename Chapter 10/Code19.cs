// Sort cars by price in ascending order
var carsByPrice = cars.OrderBy(car => car.Price).ToList();
// Sort cars by price in descending order
var carsByPriceDesc = cars.OrderByDescending(car => car.Price).ToList();