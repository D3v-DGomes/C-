/* Exercise - Addressing the challenge of specific exceptions */

/*
In this challenge, you are given a code sample that throws several different exception types. 
A single try block of code contains the code that throws the exceptions. Several catch clauses 
are included to handle specific exception types.

You need to update the code sample so that each exception is caught and the corresponding error 
message is displayed in the console.
*/

// Original code:
// try
// {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     int result = num1 + num2;
//     Console.WriteLine("Result: " + result);

//     string str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);

//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);

//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");


//---------------------------------------------------------------------------------

// My soluction:

checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }

    try
    {
        string? str = null;
        int length = str.Length;
        Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null." + ex.Message);
    }

    try
    {
        int[] numbers = new int[5];
        numbers[5] = 10;
        Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range." + ex.Message);
    }

    try
    {
        int num3 = 10;
        int num4 = 0;
        int result2 = num3 / num4;
        Console.WriteLine("Result: " + result2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
    }

}

Console.WriteLine("Exiting program.");