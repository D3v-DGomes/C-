/* Code challange - RPG Battle */

/* 
Here are the rules for the battle game that you need to implement in your code project:

- You must use the do-while statement or the while statement as an outer loop of the game;

- The hero and the monster start with 10 health points.

- All attacks have a value between 1 and 10;

- The hero attacks first;

- Print the amount of life the monster has lost and the amount it has left;

- If the monster has life (greater than zero), it can attack the hero;

- Print the amount of life the hero has lost and the amount it has left;

- Continue this sequence of attacks until the monster or the hero has no life (zero or less);

- Print the winner;
*/

int hero = 10;
int monster = 10;

Random dice = new();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");