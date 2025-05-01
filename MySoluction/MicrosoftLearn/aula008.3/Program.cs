/* Code project 3 - Write code that validates string input */
bool validEntry = false;

do
{
    Console.Write("Enter your role name (Administrator, Manager or User): ");
    // Removing spaces and leaving them in lowercase letters:
    string? roleName = Console.ReadLine().Trim().ToLower(); 

    bool onlyLetters = true;

    // Checking if the input contains only letters:
    foreach(char c in roleName)
    {
        if (!char.IsLetter(c))
        {
            Console.WriteLine("Input contains characters that are not letters. Please, try again.\n");
            onlyLetters = false;
            break; // Don't look for what has been found
        }
    }
    if (onlyLetters == true)
    {
        if (roleName == "administrator" || roleName == "manager" || roleName == "user")
        {
            validEntry = true;
            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
        }
        else
        {
            Console.WriteLine($"The role name that you entered, '{roleName}' is not valid. Enter your role name (Administrator, Manager or User). Try again.\n");
        }
    }
} while (validEntry == false);


