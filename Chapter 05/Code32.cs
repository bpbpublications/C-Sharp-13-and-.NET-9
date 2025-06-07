public void DisplayPersonInfo(Person person)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    if (person is Professor professor)
    {
        Console.WriteLine($"Subject: {professor.Subject}");
    }
    else if (person is Student student)
    {
        Console.WriteLine($"Major: {student.Major}");
    }
}