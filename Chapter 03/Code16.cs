var myList = new List<int> { 1, 2, 3, 4, 5 };
var spreadSheet = new List<string> { "A1", "B1", "C1", "D1" };
for (var i = 0; i < 10; i++)
{
// Do something 10 times
}

for (var i = 0; i < myList.Count; i++)
{
// Do something for each item in myList
}

for (var i = 1; i < spreadSheet.Count(); i++)
{
// Do something with data rows
}