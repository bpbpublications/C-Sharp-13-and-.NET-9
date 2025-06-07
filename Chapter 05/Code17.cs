public class Employee
{
    public string Name;
    public int Age;
}

// Suppose we have an Employee object that we’ve read from a database
Employee employee = GetEmployeeFromDatabase();
Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");