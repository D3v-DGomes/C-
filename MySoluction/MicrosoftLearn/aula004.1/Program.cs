/*
Exercise - Complete a challenge activity using conditional operators:

Coding Challenge: Write code to display the result of a coin flip.
Here are your challenge requirements:

1- Use the Random class to generate a value.
    a. Consider the range of numbers you need.

2- Based on the generated value, use the conditional operator to display either heads or tails.
    b. There should be a 50% chance that the result will be either heads or tails.

3- Your code should be easy to read, but in as few lines as possible.
    c. You should be able to achieve the desired result in three lines of code.
*/

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");


/*
Exercise - Complete a challenge activity using Boolean Expressions

Decision Logic Challenge:
In this challenge, you will implement decision logic based on a series of business rules. 
The business rules specify the access that will be granted to users based on their role-based 
permissions and career level. The code branches will display a different message to the user 
depending on their permissions and level.
*/

string permission = "Admin|Manager";
int level = 53;

Console.Clear();
Console.Write("Please, inform your permission: ");
string userPermission = Console.ReadLine().ToLower().Trim();

Console.Write("Please, inform your level: ");
int userLevel = Convert.ToInt32(Console.ReadLine().ToLower().Trim());

if (userPermission.Contains("admin"))
{
    if (userLevel > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (userPermission.Contains("manager"))
{
    if (userLevel >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}