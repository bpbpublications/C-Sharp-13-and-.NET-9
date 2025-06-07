// Array declaration and initialization
int[] numbers =
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9
};
// List declaration
List<int> numberList = new List<int>();
// Adding elements to the list
numberList.AddRange(numbers);
// Accessing elements by index
int firstNumber = numberList[0];
// Removing an element from the list
numberList.Remove(4);