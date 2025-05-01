// Arrays

// Creating an array with 3 elements:
string[] fraudulentOrderIDs = new string[3];

// Assigning values to array elements:
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Retrieving the value of an array element:
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Returning the value of an array element:
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}\n");

// Declaring and initializing an array with a single statement:
string[] fraudulentOrderIDsII = ["A987", "B654", "C321"];

// Retrieving the value of an array element:
Console.WriteLine($"First: {fraudulentOrderIDsII[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDsII[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDsII[2]}\n");

// Using the Length property:
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n");

// Using the foreach statement:
string[] names = {"Robin", "Sócrates", "Mary"};

foreach(string name in names) {
    Console.WriteLine($"{name}\n");
}

// EXERCISE - IMPLEMENT THE FOREACH STATEMENT: 

// Creating and initializing an array of int:
int[] inventory = {200, 450, 700, 175, 250};

// Creating a foreach statement to sum the values of the int array:
int sum = 0;
int bin = 0;

foreach(int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.\n");

// EXERCISE - COMPLETE A CHALLENGE ACTIVITY FOR NESTED ITERATION AND SELECTION STATEMENTS:
/*
Your team has discovered a pattern. Orders that start with the letter "B" are being subject to fraud
at a rate 25 times higher than normal rate. You write new code that generates the order ID of new
orders where the order ID starts whith the letter "B". This will be used by the fraud team to 
investigate further.
*/

string[] newFraudulentOrdersIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

Console.WriteLine("Orders stating with the letter B: ");
foreach(string letterB in newFraudulentOrdersIDs) {
    if(letterB.StartsWith("B")) {
        Console.WriteLine(letterB);
    }
}