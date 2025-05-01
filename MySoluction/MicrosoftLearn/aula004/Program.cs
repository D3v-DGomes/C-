// BOOLEAN EXPRESSIONS

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// Console.WriteLine(pangram.StartsWith("The"));
// Console.WriteLine(pangram.EndsWith("a"));
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(pangram.Contains("fox"));

using System.Runtime.Intrinsics.Arm;
// Logical negatopm operator:
// string newPangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!newPangram.Contains("fox"));
// Console.WriteLine(!newPangram.Contains("cow"));

// Inequality operator:
// int a = 7;
// int b = 6;

// string s1 = "Hello";
// string s2 = "Hello";

// Console.WriteLine(a != b);
// Console.WriteLine(s1 != s2);

// ----------------------------------------------------------------------------------------------------------

/* IMPLEMENT THE CONDITIONAL OPERATOR */

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// Using the built-in conditional operator:
int newSaleAmount = 1001;
Console.WriteLine($"Discount: {(newSaleAmount > 1000 ? 100 : 50)}");