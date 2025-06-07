public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Professor : Person
{
    public string Subject { get; set; }
}

public class Student : Person
{
    public string Major { get; set; }
}