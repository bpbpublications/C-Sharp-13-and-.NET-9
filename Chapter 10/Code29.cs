var luxuryCars =
    from car in cars
    where car.Price > 50000
    select car.Model;