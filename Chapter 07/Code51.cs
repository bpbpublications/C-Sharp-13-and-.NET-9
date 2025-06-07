string numberString = "123abc";
int result;
bool success = Int32.TryParse(numberString, out result);
if (success)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid Number Format");
} // Output: Invalid Number Format
