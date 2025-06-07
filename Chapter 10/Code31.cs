List<int> numbers = new List<int>
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
var filteredNumbers = numbers.Where(x => x > 5);
foreach (int number in filteredNumbers)
{
    Console.WriteLine(number);
}