/*
Exercise - Complete a challenge to reverse words in a sentence:
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
char[] sentence = pangram.ToCharArray();

Array.Reverse(sentence);
Console.WriteLine(sentence);


// Resolution proposed by the course:
string pangram1 = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram1.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);