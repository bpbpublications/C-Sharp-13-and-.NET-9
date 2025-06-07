DateTime utcTime = new DateTime(2023, 8, 11, 4, 0, 0, DateTimeKind.Utc); // 4:00 AM UTC
// Convert the UTC DateTime to AEST
DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, aestZone);
Console.WriteLine(localTime); // This will show the AEST equivalent of the provided UTC date and time
