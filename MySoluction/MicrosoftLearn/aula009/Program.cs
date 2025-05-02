/* Converter tipos de dados usando técnicas de conversão e transmissão: */

// Implicit conversion:
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");


// Explicit conversion:
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");

// Narrowing conversion:
decimal myDecimal3 = 1.23654987m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float: {myFloat}");

// Using ToString():
int frist = 5;
int second = 7;
string message = frist.ToString() + second.ToString();
Console.WriteLine(message);

// Using Parse():
string one = "5";
string two = "7";
int sum = int.Parse(one) + int.Parse(two);
Console.WriteLine(sum);

// Using Convert:
string value1 = "6";
string value2 = "9";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Explicit conversion VS Convert():
int valueI = (int)1.5m;     // The float value is truncated so that the result is 1. The value after the comma is ignored completely.
Console.WriteLine(valueI);

int valueII = Convert.ToInt32(1.5m); // The float value is rounded correctly to 2.
Console.WriteLine(valueII); 