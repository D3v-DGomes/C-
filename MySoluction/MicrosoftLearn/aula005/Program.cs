/* CONTROL THE LOGIC AND SCOPE OF VARIABLES WITH CODE BLOCKS IN C# */

// bool flag = true;
// int value = 0;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// bool flag = true;

// if (flag) Console.WriteLine(flag);

int [] numbers = {4, 8, 15, 16, 23, 42};
int total = 0;
bool found = false;

foreach(int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");      

Console.WriteLine($"Total: {total}");



