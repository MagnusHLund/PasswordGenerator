namespace Password_Generator_V2
{
    internal class Files
    {
        // Creates an instance of the Writelinse class, to do color changes and writelines
        static Writelines write = new Writelines();

        // Create an instance of the Replay class, to replay the program
        static Replay replay = new Replay();

        // Checks if files exist
        public void Exists()
        {
            // Location of directory and txt file, used for checking if they exist
            string path = @"C:\passwords";
            string file = @"\passwords.txt";

            if (!Directory.Exists(path))  // Check if directory exists, create if it doesn't
                Directory.CreateDirectory(path);

            if (!File.Exists(path + file))  // Check if file exists, create if it doesn't
                File.Create(path + file).Close();
        }

        // Writes to txt file
        public void Write(string password, string name)
        {
            // Used to verify and create files and directories
            string path = @"C:\passwords";
            string file = @"\passwords.txt";

            write.Password(password);  // Output password to console

            // The program tries to write password details, in the file. If it fails, an error is displayed.
            try
            {
                using (StreamWriter sw = File.AppendText(path + file))  // Open file for writing
                {
                    sw.WriteLine(name);  // Write password name to file
                    sw.WriteLine(password);  // Write password to file
                    sw.WriteLine();  // Write blank line to file
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine("An error occurred while writing to the file: " + exception.Message);
            }

            write.Replay();  // Console writelines and color changes
            replay.Method();  // Runs the Replay class, which gives the user the option to create a new password or close the application
        }
    }
}
