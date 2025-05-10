// Using PadLeft() and PadRight:
string input = "Pad this";
Console.WriteLine(input.PadLeft(10));
Console.WriteLine(input.PadRight(12));

Console.WriteLine("");

// Using PadLeft and PadRight with overload:
Console.WriteLine(input.PadLeft(15, '-'));
Console.WriteLine(input.PadRight(15, '-'));

/* Exercise - Discover padding and alignment */

string paymentID = "769C";
string payeeName = "Mr. Stephen Hawking";
string paymentAmount = "R$5.000,00";


var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(payeeName.Length);
formattedLine += paymentAmount.PadLeft(paymentAmount.Length + 4);

Console.WriteLine("123546579123121324687985416321987633354");
Console.WriteLine(formattedLine);