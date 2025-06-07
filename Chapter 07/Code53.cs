double value = 12345.6789;
Console.WriteLine(String.Format("{0:C}", value)); // Outputs "$12,345.68" (assuming U.S. culture)
Console.WriteLine(String.Format("{0:N2}", value)); // Outputs "12,345.68"
