using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace SecureFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            // Create and Write to File
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello, world!");
            }

            // Secure the File
            FileSecurity fileSecurity = new FileSecurity();
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            fileSecurity.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Read, AccessControlType.Allow));
            File.SetAccessControl(filePath, fileSecurity);
            // Read the File Content
            string content = File.ReadAllText(filePath);
            Console.WriteLine($"File content: {content}");
            // Show Permission
            fileSecurity = File.GetAccessControl(filePath);
            foreach (FileSystemAccessRule rule in fileSecurity.GetAccessRules(true, true, typeof(SecurityIdentifier)))
            {
                Console.WriteLine($"Identity: {rule.IdentityReference.Value}, Right: {rule.FileSystemRights}, Type: {rule.AccessControlType}");
            }
        }
    }
}