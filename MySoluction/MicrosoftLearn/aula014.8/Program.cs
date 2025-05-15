/* Create a method that returns an integer */

/*
Suppose you are visiting Vietnam and want to write a short program that converts currency. 
You can assume that the current exchange rate is 1 USD = 23500 VND. In this task, you will write 
a method that converts USD to VND.
*/

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

// Create a method that returns a double:
double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 25)));

// Create a method that returns a string:
/*
Suppose you are a candidate in a programming interview. The interviewer asks you to write a method 
to reverse a string without using string.Reverse. Take a moment to think about how you might 
accomplish this task.
*/
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 25)));

// Create a method to reverse words in a sentence:
/*
Suppose you are a candidate in a programming interview. The interviewer asks you to write a method 
to reverse a string without using string.Reverse. Take a moment to think about how you might 
accomplish this task.
*/

string sentence = "string return type";

Console.WriteLine(sentence);
Console.WriteLine(ReverseSentence(sentence));

string ReverseSentence(string sentence)
{
    string result = "";
    string[] words = sentence.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

Console.WriteLine(string.Join("", Enumerable.Repeat("-", 25)));

// Create a method that returns a Boolean:
/*
Suppose you are a candidate in a programming interview. The interviewer wants you to check if several 
words are palindromes. A word is a palindrome if it reads the same backwards and forwards. 
For example, the word racecar is a palindrome.
*/

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }
    
    return true;
}