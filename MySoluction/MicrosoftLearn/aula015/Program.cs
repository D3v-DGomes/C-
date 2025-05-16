/* Introduction to testing, debugging, and exception handling */

// string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

// int studentCount = students.Length;

// Console.WriteLine("The final name is: " + students[studentCount]);


Console.WriteLine(string.Join("", Enumerable.Repeat("-", 25)));
//---------------------------------------------------------------------------------------

/* Exercise - Implement try-catch exception handling */
// Implement a simple capture attempt:

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
catch
{
    Console.WriteLine("An exception has been caught.");
}

Console.WriteLine("Exit program");


Console.WriteLine(string.Join("", Enumerable.Repeat("-", 25)));
//-------------------------------------------------------------------------

// Catch exceptions thrown in called methods:
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}