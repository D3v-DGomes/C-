﻿/* Arrays */

string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Array.Sort():
Console.WriteLine("Sorted...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array.Reverse():
Console.WriteLine("");
Console.WriteLine("Reserved...");
Array.Reverse(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array.Clear():
Console.WriteLine("");
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);

if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array.Resize():
Console.WriteLine("");
Array.Resize(ref pallets, 6);   // adding elements
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);   // removing elements
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Array methods of String data type:
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);

string result = new string(valueArray);
Console.WriteLine(result);

// Using .Join():
Console.WriteLine("");
string joinResult = String.Join(",", valueArray);
Console.WriteLine(joinResult);

// Using .Split():
Console.WriteLine("");
string[] items = joinResult.Split(',');

foreach (string item in items)
{
    Console.WriteLine(item);
}