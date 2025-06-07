double sampleNumber = 12345.6789;
// C or c: Currency
Console.WriteLine(String.Format("Currency: {0:C}", sampleNumber)); // Outputs "$12,345.68" for en-US culture
// D or d: Decimal (used for integral types only)
Console.WriteLine(String.Format("Decimal: {0:D}", 12345)); // Outputs "12345"
// E or e: Scientific
Console.WriteLine(String.Format("Scientific: {0:E}", sampleNumber)); // Outputs "1.234568E+004"
// F or f: Fixed-point
Console.WriteLine(String.Format("Fixed-point: {0:F2}", sampleNumber)); // Outputs "12345.68"
// G or g: General
Console.WriteLine(String.Format("General: {0:G}", sampleNumber)); // Outputs "12345.6789"
// N or n: Number
Console.WriteLine(String.Format("Number: {0:N2}", sampleNumber)); // Outputs "12,345.68"
// P or p: Percent
Console.WriteLine(String.Format("Percent: {0:P2}", 0.123456789)); // Outputs "12.35%"
// R or r: Round-trip
Console.WriteLine(String.Format("Round-trip: {0:R}", sampleNumber)); // Outputs "12345.6789"
// X or x: Hexadecimal (used for integral types only)
Console.WriteLine(String.Format("Hexadecimal: {0:X}", 255)); // Outputs "FF"
