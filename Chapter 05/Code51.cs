// Creating an object of the Employee class
Employee emp = new Employee("John", 30);
Console.WriteLine(emp.Name); // Outputs: John
Console.WriteLine(emp.Age); // Outputs: 30
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Parameterized constructor
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}