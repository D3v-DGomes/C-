/* Iterate through code block using a statement in C# */

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    // Use the break keyword to break the iteration statement:
    if (i == 7) break;
}

// Looping through each element of an array:
string[] names = {"Alex", "Eddie", "David", "Michael"};

for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// Examining the limitation of the foreach statement:
// string[] names1 = {"Baldur", "Eliie", "David", "Antony"};

// foreach(var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sunny";
// }
Console.Clear();
// Overcoming the limitation of foreach statement using for statement:
string[] names2 = {"Tyr", "Thor", "Freya", "Loky"};

for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "Freya") names2[i] = "Odin";

foreach(var name in names2) Console.WriteLine(name);