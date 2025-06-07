// Sample list of integers
List<int> numbers = new List<int>
{
    1,
    2,
    3,
    4,
    5
};
// LINQ query to filter even numbers (postponed execution)
var evenNumbersQuery = numbers.Where(n => n % 2 == 0);
// At this point, the query hasn't been executed yet
Console.WriteLine("Query created but not executed yet.");
// Enumerating the query triggers its execution
foreach (var number in evenNumbersQuery)
{
    Console.WriteLine(number);
}