GreetPerson("John"); // prints "Hello, John!"
GreetPerson("John", "Goodbye"); // prints "Goodbye, John!"
static void GreetPerson(string name, string greeting = "Hello")
{
    Console.WriteLine(greeting + ", " + name + "!");
}