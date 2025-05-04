/*
Exercise - Complete a challenge to produce mathematical operations as specific number types.
*/

int value = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result = Convert.ToInt32(value / value2);
Console.WriteLine($"Divide value by value2, display the result as an int: {result}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value;
Console.WriteLine($"Divide value3 by value1, display the result as an float: {result3}");