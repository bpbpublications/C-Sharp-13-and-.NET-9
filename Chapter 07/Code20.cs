string str = "Microsoft C#";
char thirdCharacter = str[2]; // 0-based index, so [2] gets the third character
Console.WriteLine($"The third character of the string ’{str}’ is: {thirdCharacter}");
Console.WriteLine($"Characters in the string ’{str}’:");
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i]);
}