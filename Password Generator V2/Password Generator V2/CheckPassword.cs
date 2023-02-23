namespace Password_Generator_V2
{
    internal class CheckPassword
    {
        // Checks if the password has 2 or more numbers
        public bool TwoNumbers(string password)
        {
            int count = 0;
            foreach (char c in password) // Loop through each character in the password
            {
                if (char.IsDigit(c)) // Check if the character is a digit
                {
                    count++; // Increment the count if the character is a digit
                    if (count >= 2) // If there are at least 2 digits, return true
                    {
                        return true;
                    }
                }
            }
            return false; // Otherwise, return false
        }

        //  Checks if the password has both upper and lower case characters
        public bool HasMixedCase(string password)
        {
            bool hasUppercase = false;
            bool hasLowercase = false;

            foreach (char c in password) // Loop through each character in the password
            {
                if (char.IsUpper(c)) // Check if the character is uppercase
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(c)) // Check if the character is lowercase
                {
                    hasLowercase = true;
                }

                if (hasUppercase && hasLowercase) // If there are both uppercase and lowercase characters, return true
                {
                    return true;
                }
            }
            return false; // Otherwise, return false
        }
    }
}
