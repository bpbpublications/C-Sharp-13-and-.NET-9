public class Employee
{
    public string Name;
    public int Age;
}

// Create a new Employee object
Employee newEmployee = new Employee();
newEmployee.Name = "John Doe";
newEmployee.Age = 30;
// Write this object to the database
WriteEmployeeToDatabase(newEmployee);