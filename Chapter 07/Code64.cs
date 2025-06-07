double value = 1234567.89;
// en-US: United States
Console.WriteLine(String.Format(new CultureInfo("en-US"), "{0:C}", value)); // Outputs "$1,234,567.89"
// de-DE: Germany
Console.WriteLine(String.Format(new CultureInfo("de-DE"), "{0:C}", value)); // Outputs "1.234.567,89 €"
// fr-FR: France
Console.WriteLine(String.Format(new CultureInfo("fr-FR"), "{0:C}", value)); // Outputs "1 234 567,89 €"
// ru-RU: Russia
Console.WriteLine(String.Format(new CultureInfo("ru-RU"), "{0:C}", value)); // Outputs "1 234 567,89 ₽"
