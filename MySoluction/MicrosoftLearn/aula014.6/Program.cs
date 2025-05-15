/*
Challenge - Tell a Fortune

You are helping to develop a massively multiplayer role-playing game. Each player has a luck statistic 
that can affect their chances of finding rare treasures. Every day, a player can speak to an in-game 
fortune teller who reveals whether their luck statistic is high, low, or neutral.

The game currently has code to generate a player's fortune, but it is not reusable. Your task is to create 
a tellFortune method that can be called at any time and replace the existing logic with a call 
to your method.

In this challenge, you are given some starter code. You must decide how to create and call the tellFortune 
method.
*/

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}