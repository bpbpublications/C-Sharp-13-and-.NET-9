List<Person> people = new List<Person>
{
    new Person
    {
        Name = "Alice",
        Age = 30
    },
    new Person
    {
        Name = "Bob",
        Age = 25
    },
    new Person
    {
        Name = "Charlie",
        Age = 25
    },
    new Person
    {
        Name = "David",
        Age = 35
    }
};
var sortedPeople = people.OrderBy(p => p, new PersonComparer()).ToList();
foreach (var person in sortedPeople)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int ageComparison = x.Age.CompareTo(y.Age);
        if (ageComparison == 0)
        {
            return x.Name.CompareTo(y.Name);
        }

        return ageComparison;
    }
}