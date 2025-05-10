/* 
Exercise - Complete a challenge to extract, replace, and remove data from an input string

Examine the desired output for the final output of the program:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here:

// Starting with the quantity:
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPositionQuantity = input.IndexOf(openSpan);
int closingPositionQuantity = input.IndexOf(closeSpan);

openingPositionQuantity += openSpan.Length;

int lengthQuantity = closingPositionQuantity - openingPositionQuantity;
quantity += $"Quantity: {input.Substring(openingPositionQuantity, lengthQuantity)}";

// Output:
const string openH2 = "<h2>";

int openingPositionOutput = input.IndexOf(openH2);
int closingPositionOutput = input.IndexOf(closeSpan);

int lengthOutput = closingPositionOutput - openingPositionOutput;
output += $"Output: {input.Substring(openingPositionOutput, lengthOutput).Replace("trade", "reg")}";

Console.WriteLine(quantity);
Console.WriteLine(output);

// --------------------------------------------------------------------------------------------------------

// Solution proposed in the course:

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// Extract the "quantity"
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
// int quantityEnd= input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// // Remove the opening <div> tag
// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// output = output.Remove(divStart, openDiv.Length);

// // Remove the closing </div> tag and add "Output:" to the beginning
// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine(quantity);
// Console.WriteLine(output);