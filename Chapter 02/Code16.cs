int[] arrNumber1 =
{
    1,
    2,
    3
};
// arrNumber2 points to the same array as arrNumber1
int[] arrNumber2 = arrNumber1;
// Modifying arrNumber1 also modifies arr2
arrNumber1[0] = 10;
Console.WriteLine(arrNumber1[0]); // Output: 10
Console.WriteLine(arrNumber2[0]); // Output: 10
Console.ReadKey();