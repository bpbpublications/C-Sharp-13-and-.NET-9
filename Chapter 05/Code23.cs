public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

string connectionString = "Your Connection String";
using var connection = new NpgsqlConnection(connectionString);
connection.Open();
List<Employee> employees = new List<Employee>
{
    new Employee("John Doe", 30),
    new Employee("Jane Smith", 35),
    new Employee("Mike Johnson", 40),
    new Employee("Emily Davis", 25),
    new Employee("Daniel Miller", 45),
    new Employee("Sarah Brown", 28)
};
foreach (Employee employee in employees)
{
    WriteEmploye(employee, connection);
}

static void WriteEmploye(Employee newEmployee, NpgsqlConnection connection)
{
    using var command = new NpgsqlCommand("INSERT INTO Employees (Name, Age) VALUES (@Name, @Age)", connection);
    command.Parameters.AddWithValue("Name", newEmployee.Name);
    command.Parameters.AddWithValue("Age", newEmployee.Age);
    command.ExecuteNonQuery();
}