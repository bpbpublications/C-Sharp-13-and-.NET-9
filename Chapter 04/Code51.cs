List<(string FirstName, string LastName, int Age)> employees = GetEmployeeData();
foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Age: {employee.Age}");
}

public static List<(string FirstName, string LastName, int Age)> GetEmployeeData()
{
    List<(string, string, int)> employeeData = new List<(string, string, int)>
    {
        ("John", "Doe", 30),
        ("Jane", "Smith", 25),
        ("Michael", "Johnson", 35),
    };
    return employeeData;
}