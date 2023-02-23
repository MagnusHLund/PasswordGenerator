using System.Text;  // for StringBuilder class

namespace Password_Generator_V2
{
    internal class PasswordGenerator
    {
        // Title for passwordd
        static string name = "";

        // Create an instance of the CheckPassword class, to check if the password has the minimum requirements
        static CheckPassword check = new CheckPassword();

        // Creates an instance of the Writelinse class, to do color changes and writelines
        static Writelines write = new Writelines();

        // Create an instance of the VerifyFiles class, to check if files and directories exist
        static Files files = new Files();

        // Prompts the user to create a name for the password
        public  void Name()
        {
            write.Name(); // Console writelines and color changes
            name = "" + Console.ReadLine(); // Name because whatever the user inputs

            Length(); // Calls the Length method
        }

        // Prompts the user to input desired length
        void Length()
        {
            write.Length();  // Console writelines and color changes

            string lengthString = "" + Console.ReadLine(); // User input becomes the lengthString

            if (int.TryParse(lengthString, out int length))  // Check if input is a valid integer
            {
                if (length < 6)  // Verify minimum password length
                {
                    write.Minimum();  // Console writelines and color changes
                    Length();  // Prompt user to input desired length again
                }
                else
                {
                    Create(length);  // Create password with given length
                }
            }
            else
            {
                write.Invalid();  // Console writelines and color changes
                Length();  // Prompt user to input desired length again
            }
        }

        // Creates password with given length
        void Create(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; // Password can be created using these characters
            var random = new Random();  // Random number generator
            var password = new StringBuilder(length);
            password.Append("@");  // Add '@' to the beginning of the password
            for (int i = 1; i < length; i++)  // Start generating characters from the second character
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            Verify(password.ToString(), length);  // Verify password meets minimum requirements
        }

        // Verifies minimum requirements
        void Verify(string password, int length)
        {
            if (check.TwoNumbers(password) && check.HasMixedCase(password))  // Check if password has 2 or more numbers and has both upper and lower case characters
                files.Write(password, name);  // Write password to txt file
            else
                Create(length);  // Generate new password that meets minimum requirements
        }
    }
}
