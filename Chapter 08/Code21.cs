// Create
File.Create("example.txt");
// Exists
bool exists = File.Exists("example.txt");
// Read all text
string content = File.ReadAllText("example.txt");
// Write all text
File.WriteAllText("example.txt", "Hello World!");
// File delete
File.Delete("example.txt");