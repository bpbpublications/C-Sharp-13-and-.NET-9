// Create
Directory.CreateDirectory("NewFolder");
// Exists
bool exists = Directory.Exists("NewFolder");
// Get files
string[] files = Directory.GetFiles("NewFolder");
// Get directories
string[] dirs = Directory.GetDirectories("NewFolder");
// Delete
Directory.Delete("NewFolder", true);