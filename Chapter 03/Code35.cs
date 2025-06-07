using Microsoft.Data.SqlClient;

try
{
    // Open a database connection
    using SqlConnection myConnection = new SqlConnection(myConnectionString);
    myConnection.Open();
    // Execute a database query
    using SqlCommand myCommand = new SqlCommand("SELECT * FROM Produtcs", myConnection);
    using SqlDataReader myReader = myCommand.ExecuteReader();
    // Process the query results
    while (myReader.Read())
    {
    // Process each row
    }
}
catch (SqlException ex)
{
    Console.WriteLine($"A SQL error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
// Clean up resources or perform necessary
// actions, such as closing the connection
}