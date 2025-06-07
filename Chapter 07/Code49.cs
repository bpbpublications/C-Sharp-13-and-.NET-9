string dateString = "2023-08-32"; // Invalid Date
DateTime result;
bool success = DateTime.TryParse(dateString, out result);
if (success)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid Date Format");
} // Output: Invalid Date Format
