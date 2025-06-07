Book book1 = new Book();
book1.Title = "Moby Dick";
book1.Author = "Herman Melville";
book1.ISBN = "1234567890";
book1.IsBorrowed = false;
book1.Borrow(); // Outputs: "Moby Dick has been borrowed."
book1.Return(); // Outputs: "Moby Dick has been returned."
