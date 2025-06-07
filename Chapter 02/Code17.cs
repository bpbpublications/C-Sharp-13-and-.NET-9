int[] myArray =
{
    1,
    2,
    3
};
// Modifies the original array
ModifyArray(myArray);
// Output: 100
Console.WriteLine(myArray[0]);
Console.ReadKey();
void ModifyArray(int[] array)
{
    array[0] = 100;
}