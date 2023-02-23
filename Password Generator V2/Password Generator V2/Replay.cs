namespace Password_Generator_V2
{
    internal class Replay
    {
        public void Method()
        {
            // Creates an instance of the PasswordGenerator class, to create passwords
            PasswordGenerator pass = new PasswordGenerator();

            string input = "" + Console.ReadLine(); // input becomes user input, written in the console

            // if user answers y then you can create another password. if input is n, the program closes. else, run this method again.
            if (input.ToLower() == "y")
            {
                pass.Name();  // Starts the progress to create a new password, in PasswordGenerator
            }
            else if (input.ToLower() == "n")
            { 
                Environment.Exit(0);  // Closes the application
            }
            else
            {
                Method();  // restarts this method
            }
        }
    }
}
