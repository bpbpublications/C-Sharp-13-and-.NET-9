IEnumerable<int> numbers = new List<int>
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10
};
IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);
// At this point, the query has not been executed.
// Execution happens here.
foreach (var n in evenNumbers)
{
    Console.WriteLine(n);