IProduct book = new Book("Clean Code", 50.00m);
IProduct electronics = new Electronics("Laptop", 1500.00m);
book.ApplyDiscount(5.00m);
electronics.ApplyDiscount(100.00m);
book.DisplayDetails(); // Outputs: Book: Clean Code, Price: 45.00
electronics.DisplayDetails(); // Outputs: Electronics: Laptop, Price: 1400.00
