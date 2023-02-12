void Main()
{
    while (true)
    {
        PasswordValidator.InputPasscode();
    }
}

Main();

class PasswordValidator
{
    public static string InputPasscode()
    {
        Console.WriteLine("Please enter a password.");
        Console.WriteLine("Password must be between 6 and 13 letters long");
        Console.WriteLine("Password must have one uppercase letter, one lowercase letter, and one number");
        Console.WriteLine("Password cannot contain the letter 'T' nor and ampersand (&)");
        string codeInput = "";
        bool lengthMatch = false;
        bool uppercaseMatch = false;
        bool lowercaseMatch = false;
        bool numberMatch = false;
        bool invalidMatch = false;

        codeInput = Console.ReadLine().Trim();

        if (codeInput.Length > 5 && codeInput.Length < 14)
        {
            lengthMatch = true;
        }

        foreach(char testChar in codeInput)
        {
            if (Char.IsUpper(testChar))
                uppercaseMatch = true;
            if (Char.IsLower(testChar))
                lowercaseMatch = true;
            if (Char.IsNumber(testChar))
                numberMatch = true;
            if(testChar == 'T' || testChar == '&')
                invalidMatch = true;
        }

        Console.Clear();

        if (lengthMatch && uppercaseMatch && lowercaseMatch && numberMatch && !invalidMatch)
            Console.WriteLine("Password is valid");
        else
            Console.WriteLine("Password is invalid");

        return codeInput;
    }
}