public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Default constructor
    public Employee()
    {
        Name = "Not Specified";
        Age = 0;
    }
}

// Creating an object of the Employee class
Employee emp = new Employee();
Console.WriteLine(emp.Name); // Outputs: Not Specified
Console.WriteLine(emp.Age); // Outputs: 0
