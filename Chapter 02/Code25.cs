// Sunday as an underlying integer value
int enumValue = 6;
// Convert integer to enum
DaysOfWeek day = (DaysOfWeek)enumValue;
Console.WriteLine($"Converted value: {day}"); // Output Sunday
// Convert enum to integer
int intValue = (int)day;
Console.WriteLine($"Converted value: {intValue}"); // Output 6
Console.ReadKey();
enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}