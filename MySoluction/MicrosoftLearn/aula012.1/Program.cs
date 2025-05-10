/* Exercise - Explore string interpolation */

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Display product shares with accuracy to one thousandth of a share (0.001):
Console.WriteLine($"\tShares: {productShares:N3}");
// Display the subtotal you charge the customer formatted as currency:
Console.WriteLine($"\t\tSub total: {subtotal:C2}");
// Display the tax charged on the sale formatted as a percentage:
Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");
// Finalize the receipt with the total amount due formatted as currency:
Console.WriteLine($"\t\tTotal Billed: {total:C2}");
