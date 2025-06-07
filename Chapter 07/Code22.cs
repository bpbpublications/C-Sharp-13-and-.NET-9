// Convert DateTime to Unix timestamp
DateTime someDateTime = new DateTime(2023, 8, 11);
long unixTimestamp = (someDateTime.Ticks - new DateTime(1970, 1, 1).Ticks) / TimeSpan.TicksPerSecond;
// Convert Unix timestamp back to DateTime
DateTime originalDate = new DateTime(1970, 1, 1).AddSeconds(unixTimestamp);