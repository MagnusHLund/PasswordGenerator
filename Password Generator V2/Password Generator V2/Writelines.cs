namespace Password_Generator_V2
{
    internal class Writelines
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Changes console color to cyan
            Console.WriteLine("12 characters takes 34000 years to crack, using special characters, numbers, lower and upper case, March 2022\n"); // Writes in console
        }

        public void Name()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Changes color to blue
            Console.WriteLine("Write the title for this password"); // Writes in the console
            Console.ForegroundColor = ConsoleColor.Green; // Changes color to green
        }

        public void Length()
        {
            Console.WriteLine(); // Empty line, for layout
            Console.ForegroundColor = ConsoleColor.Blue; // Changes color to blue
            Console.WriteLine("Write the length for this password"); // Writes in the console
            Console.ForegroundColor = ConsoleColor.Green; // Changes color to green
        }

        public void Minimum()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changes color to red
            Console.WriteLine("Minimum length is 6"); // Writes in the console
        }

        public void Invalid()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Changes color to red
            Console.WriteLine("Input is invalid. Numbers only."); // Writes in the console
        }

        public void Password(string password)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Changes color to blue
            Console.WriteLine("\nYour password is:"); // Writes in console
            Console.ForegroundColor = ConsoleColor.Green; // Changes color to green
            Console.WriteLine(password); // Writes the password to the console.
        }

        public void Replay()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Chanes the color to blue
            Console.WriteLine("Wanna create a new password? y/n"); // Writes in the console
            Console.ForegroundColor = ConsoleColor.Green; // Changes color to green
        }
    }
}
