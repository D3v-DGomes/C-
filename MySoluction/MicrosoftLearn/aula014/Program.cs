/* Methods with parameters */

// example I:
using System.Net.NetworkInformation;

CountTo(5);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 20)));
// --------------------------------------------------------------------------------------------

/*
In this task, you will create a method that adjusts scheduled times to a different GMT time zone. 
The method must accept a list of times, the current time zone, and the new time zone.
*/

int[] schedule = [800, 1200, 1600, 2000];

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT.");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 20)));
// --------------------------------------------------------------------------------------------

/* Understanding the scope of the method */

string[] students = { "Jenna", "Ayesha", "Carlos", "Vitor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vânia" });

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.WriteLine($"{student},");
    }
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 20)));
// --------------------------------------------------------------------------------------------

double pi = 3.14159;
PrintCircleArea(12);
PrintCircleCircumference(10);
PrintCircleInfo(12);
PrintCircleInfo(14);

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius); // methods can call other methods
    PrintCircleCircumference(radius); // methods can call other methods
}