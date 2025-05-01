/* Do-while and While */

// Exercise - Create "do" and "while" iteration loops 

// do
// {
//     // This code executes at least one time
// } while (true);

// Write a do-while statement to stop if a certain random number is generated:
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

Console.Clear();

// Write a while statement that iterates only while a random number is greater than some value:
Random random2 = new Random();
int current2 = random.Next(1 ,11);

while (current2 >= 4)
{
    Console.WriteLine(current2);
    current2 = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current2}");

Console.Clear();

// Usign the Continue statement:
Random random3 = new();
int current3 = random.Next(1, 11);

do
{
    current3 = random.Next(1, 11);

    if (current3 >= 8) continue;

    Console.WriteLine(current3);
} while (current3 != 7);

Console.Clear();

// string? readResult;
// Console.WriteLine("Enter a string:");

// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);