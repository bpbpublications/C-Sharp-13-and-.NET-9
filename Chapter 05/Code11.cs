using Microsoft.Data.SqlClient;

IEnumerable<Book> ReadRecords(string connectionString)
{
    using var connection = new SqlConnection(connectionString);
    try
    {
        connection.Open();
        using var command = new SqlCommand("SELECT Title, Author, ISBN FROM dbo.Books", connection);
        {
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader.GetString(0); // Assumes that Title is in the first column
                string author = reader.GetString(1); // Assumes that Author is in the second column
                string isbn = reader.GetString(2); // Assumes that ISBN is in the third column
                var book = new Book(title, author, isbn);
                yield return book;
            }
        }
    }
    finally
    {
        connection.Close();
    }
}

var books = ReadRecords("Your Connection String");
foreach (Book book in books)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
}