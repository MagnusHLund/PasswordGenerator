using Password_Generator_V2;
namespace Password_generator_V2
{
    internal class Program
    {
        // Create an instance of the VerifyFiles class, to check if files and directories exist
        static Files files = new Files();

        // Creates an instance of the Writelinse class, to do color changes and writelines
        static Writelines write = new Writelines();

        // Creates an instance of the PasswordGenerator class, to create passwords
        static PasswordGenerator pass = new PasswordGenerator();

        // calls Exists and Name methods
        static void Main()
        {
            write.Start();  // Perform writelines and color changes, for the start of the application
            files.Exists();  // Check if files and directories exist
            pass.Name();  // Calls the Name method
        }
    }
}