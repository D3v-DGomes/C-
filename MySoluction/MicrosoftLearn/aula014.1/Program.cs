/* Methods with value and reference type parameters */

// Pass-by-value testing
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"Global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 20)));
// -----------------------------------------------------------------------------------

// Passing the test by reference
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i}");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 20)));
// ---------------------------------------------------------------------------------------

// Testing with strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}