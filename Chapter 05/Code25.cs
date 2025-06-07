string greeting = MakeGreeting("John");
Console.WriteLine(greeting);
static string MakeGreeting(string name)
{
    return "Hello, " + name + "!";
}