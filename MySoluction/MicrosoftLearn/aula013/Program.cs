/* Modify the contents of strings with built-in string data type methods in C# */

string message = "Find what is (inside the parantheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// Add code to retrieve the value in parentheses and Modify the starting position of the subsequence:
openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// -------------------------------------------------------------------------------

string newMessage = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>"; 
const string closeSpan = "</span>";

int newOpeningPosition = newMessage.IndexOf(openSpan);
int newClosingPosition = newMessage.IndexOf(closeSpan);

newOpeningPosition += openSpan.Length; // ignoring the boot index

int newLength = newClosingPosition - newOpeningPosition;
Console.WriteLine(newMessage.Substring(newOpeningPosition, newLength));

Console.WriteLine();

// -------------------------------------------------------------------------------

// IndexOf and LastIndexOf:
string greetingMessage = "hello, there!";

int first_h = greetingMessage.IndexOf('h');
int last_h = greetingMessage.LastIndexOf('h');

Console.WriteLine($"For the message: '{greetingMessage}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

Console.WriteLine("");

// Retrieve the last occurrence of a subestriinst;

string messagesInParentheses = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPositionInParentheses = messagesInParentheses.LastIndexOf('(');

openingPositionInParentheses += 1;  // ignoring the boot index

int closingPositionInParentheses = messagesInParentheses.LastIndexOf(')');
int lengthInParentheses = closingPositionInParentheses - openingPositionInParentheses;

Console.WriteLine(messagesInParentheses.Substring(openingPositionInParentheses, lengthInParentheses));
Console.WriteLine();

// Retrieve all instances of substrings enclosed in parentheses:
string allMessages = "(What if) I am (only interested) in the last (set of parentheses)?";

while (true)
{
    int openingAllPosition = allMessages.IndexOf('(');
    if (openingAllPosition == -1) break;

    openingAllPosition += 1;
    int closingAllPosition = allMessages.IndexOf(')');
    int lengthAllMessages = closingAllPosition - openingAllPosition;
    Console.WriteLine(allMessages.Substring(openingAllPosition, lengthAllMessages));

    allMessages = allMessages.Substring(closingAllPosition + 1); // remove parentheses already identified
}
Console.WriteLine();

// ---------------------------------------------------------------------------------------------------------

// Work with different types of symbol sets with IndexOfAny():
string anyMessage = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS message: {anyMessage}");

char[] openSymbols = {'[', '{', '('};
int startPosition = 5;
int openingAnyMessagePosition = anyMessage.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {anyMessage.Substring(openingAnyMessagePosition)}");

openingAnyMessagePosition = anyMessage.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition: {startPosition}: {anyMessage.Substring(openingAnyMessagePosition)}");
Console.WriteLine();

// adding closing symbol to the above code logic:
string newAnyMessage = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] newOpenSymbols = {'[', '{', '('};
int newClosingAnyMessagePosition = 0;

while (true)
{
    int newOpeningAnyMessagePosition = newAnyMessage.IndexOfAny(newOpenSymbols, newClosingAnyMessagePosition);
    if (newOpeningAnyMessagePosition == -1) break;

    string currentSymbolInAnyMessage = newAnyMessage.Substring(newOpeningAnyMessagePosition, 1);

    // Now find the matching closing symbol:
    char matchingSymbol = ' ';

    switch (currentSymbolInAnyMessage)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 
    newOpeningAnyMessagePosition += 1;
    newClosingAnyMessagePosition = newAnyMessage.IndexOf(matchingSymbol, newOpeningAnyMessagePosition);

    // Finally, use the techniques you've already learned to display the sub-string:
    int newLengthAnyMessage = newClosingAnyMessagePosition - newOpeningAnyMessagePosition;
    Console.WriteLine(newAnyMessage.Substring(newOpeningAnyMessagePosition, newLengthAnyMessage));
}
Console.WriteLine("");

// ---------------------------------------------------------------------------------------------------------

/* Remove() and Replace() */

// Using Remove():
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

// Using Replace():
string messageReplace = "This--is--ex-amp-le--da-ta";
messageReplace = messageReplace.Replace("--", " ");
messageReplace = messageReplace.Replace("-", "");

Console.WriteLine(messageReplace);