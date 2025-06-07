var person = GetPerson();
(string personName, int personAge) = person;
(string personName, int personAge) GetPerson()
{
    return ("Jefferson", 22);
}

Console.WriteLine($"Name: {personName}, Age: {personAge}");