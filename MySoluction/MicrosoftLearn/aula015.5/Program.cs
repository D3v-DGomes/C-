﻿/* Exercise - Complete a challenge activity to create and throw exceptions  */

/*
In this challenge, you start with a sample application that uses a series of method calls to process 
data. The top-level statements create an array of user input values ​​and call a method called Workflow1. 
Workflow1 represents a high-level workflow that iterates through the array and passes user input 
values ​​to a method called Process1. Process1 uses the user input data to calculate a value.

Currently, when Process1 encounters a problem or error, it returns a string describing the 
problem instead of throwing an exception. Your challenge is to implement exception handling in the 
sample application.
*/

// Original code:
// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// string overallStatusMessage = "";

// overallStatusMessage = Workflow1(userEnteredValues);

// if (overallStatusMessage == "operating procedure complete")
// {
//     Console.WriteLine("'Workflow1' completed successfully.");
// }
// else
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(overallStatusMessage);
// }

// static string Workflow1(string[][] userEnteredValues)
// {
//     string operationStatusMessage = "good";
//     string processStatusMessage = "";

//     foreach (string[] userEntries in userEnteredValues)
//     {
//         processStatusMessage = Process1(userEntries);

//         if (processStatusMessage == "process complete")
//         {
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             Console.WriteLine(processStatusMessage);
//             Console.WriteLine();
//             operationStatusMessage = processStatusMessage;
//         }
//     }

//     if (operationStatusMessage == "good")
//     {
//         operationStatusMessage = "operating procedure complete";
//     }

//     return operationStatusMessage;
// }

// static string Process1(String[] userEntries)
// {
//     string processStatus = "clean";
//     string returnMessage = "";
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 returnMessage = "Invalid data. User input values must be non-zero values.";
//                 processStatus = "error";
//             }
//         }
//         else
//         {
//             returnMessage = "Invalid data. User input values must be valid integers.";
//             processStatus = "error";
//         }
//     }

//     if (processStatus == "clean")
//     {
//         returnMessage = "process complete";
//     }

//     return returnMessage;
// }


// My soluction:
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed seccessfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error ocurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}