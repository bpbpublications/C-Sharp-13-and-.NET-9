// Skip the first 2 cars and then take the next 3
var pagedCars = cars.Skip(2).Take(3).ToList();