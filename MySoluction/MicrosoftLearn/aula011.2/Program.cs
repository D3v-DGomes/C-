/* 
Exercise - Complete a challenge to analyze a sequence of orders, classify the orders and
mark possible errors:

Data comes in many formats. In this challenge, you have to parse the individual "Order IDs"
and produce the "OrderIDs" that are sorted and marked as "Error" if they are not exactly
four characters long.
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(',');
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if (orderID.Length != 4)
    {
        Console.WriteLine($"{orderID} - Error");
    }
    else 
    {
        Console.WriteLine(orderID);
    }
}