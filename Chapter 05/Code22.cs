using System.Collections.Generic;
using Npgsql;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

IEnumerable<Employee> GetEmployees()
{
    var connectionString = "Your Connection String";
    using var connection = new NpgsqlConnection(connectionString);
    connection.Open();
    using var command = new NpgsqlCommand("SELECT Name, Age FROM Employees", connection);
    using var reader = command.ExecuteReader();
    while (reader.Read())
    {
        string name = reader.GetString(0); // Assumes that Name is in the first column
        int age = reader.GetInt32(1); // Assumes that Age is in the second column
        yield return new Employee
        {
            Name = name,
            Age = age
        };
    }
}