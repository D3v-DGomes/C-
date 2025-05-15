/* Project - Petting Zoo */

/*
Suppose you are an event coordinator for a zoo. You must regularly coordinate visits from different 
schools and organize animal visits for various groups of students. You decide to write an application 
that helps you plan school visits. The application divides students into groups and assigns 
them a set of animals to visit. The students will rotate between groups after visiting their 
assigned animals. You decide to randomize the order of the animals so that each school's visit is unique.

This module will guide you through the steps required to develop your zoo application. Your code 
will use methods to plan a visit to three schools, randomize the order of the animals, assign 
students to groups, and display the results. You will use methods that accept parameters and return 
values, and you will also include some optional parameters.

The design specification for the Contoso Petting Zoo app is as follows:

There are currently three visiting schools

- School A has six groups of visitors (the default number)
- School B has three groups of visitors
- School C has two groups of visitors

For each visiting school, perform the following tasks:

1- Randomize the animals;
2- Assign the animals to the correct number of groups;
3- Print the name of the school;
4- Print the animal groups.
*/

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// Plan your code using methods:
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
    Console.WriteLine();
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

}

// Create a method with an optional parameter:
string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }
    return result;
}

// Create a method to display the results:
void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");

        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}