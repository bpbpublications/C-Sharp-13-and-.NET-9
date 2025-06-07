// Creating an object of the Employee class
Employee emp = new Employee("John", 30);
Console.WriteLine(emp.Name); // Outputs: John
Console.WriteLine(emp.Age); // Outputs: 30
public class Person
{
    public string Name { get; set; }

    // Base class constructor
    public Person(string name)
    {
        Name = name;
    }
}

public class Employee : Person
{
    public int Age { get; set; }

    // Derived class constructor
    public Employee(string name, int age) : base(name)
    {
        Age = age;
    }
}