/* Code project 1 - Write a code that validates the input of integers. */
using System.IO.Pipelines;

string? readResult;
int numericValue = 0;
bool validNumber = false;


Console.WriteLine("Enter an integer betwenn 5 and 10:");

do
{
    readResult = Console.ReadLine();
    // Checking if input has only numbers:
    if (int.TryParse(readResult, out numericValue))
    {
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
            Console.WriteLine("Input accepted successfully.");
        }
        else
        {
            Console.WriteLine($"You typed ''{numericValue}''. Please, enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine($"You typed ''{readResult}''. Input is not an integer.");
    }

} while (validNumber == false);