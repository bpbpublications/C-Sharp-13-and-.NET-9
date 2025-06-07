// Assuming your DateTime is in AEST
DateTime aestDateTime = new DateTime(2023, 8, 11, 14, 0, 0, DateTimeKind.Unspecified); // 2:00 PM AEST
// Get the Australian Eastern Standard Time zone (considering daylight saving)
TimeZoneInfo aestZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
// Convert the AEST DateTime to UTC
DateTime utcDateTime = TimeZoneInfo.ConvertTimeToUtc(aestDateTime, aestZone);
Console.WriteLine(utcDateTime); // This will show the UTC equivalent of the provided AEST date and time
