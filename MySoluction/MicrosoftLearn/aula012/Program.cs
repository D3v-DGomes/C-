// Alphanumeric data formatting:
using System.Runtime.InteropServices;

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);

Console.WriteLine(result);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

Console.WriteLine("");

// Format values for currency display:
decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // Number formatting as currency

Console.WriteLine("");

// Formatting large numbers:
decimal measurement = 123456.78912m;
int largeNumbers = 120598593;

Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Large Number: {largeNumbers:N3}");

Console.WriteLine("");

// Formatting the percentages:
decimal tax = .36785m;
int taxInt = 100;

Console.WriteLine($"Tax rate: {tax:P2}");
Console.WriteLine($"Int tax rate: {taxInt:P2}");

Console.WriteLine("");

// Combining formatting:
decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price2 - salePrice), price2);
yourDiscount += $" A discount of {((price2 - salePrice)/price2):P2}";

Console.WriteLine(yourDiscount);
