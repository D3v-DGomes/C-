/*
Exercise - Complete a challenge activity using switch statements

Code Challenge: Rewrite if-elseif-else using a switch statement:
You'll start with code that uses an if-elseif-else construct to evaluate the components of a product SKU. 
The SKU (Stock Keeping Unit) is formatted using three encoded values: 
<product #>-<2-letter color code>-<size code>. For example, a SKU value of 01-MN-L corresponds to 
(sweat shirt)-(maroon)-(large), and the code generates a description that appears as "Product: Large 
Maroon Sweat shirt."

Your challenge is to convert the statement code into a switch statement that achieves the same 
result as the initial if code.
*/

string sku = "01-MN-L" ;

string [] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

/* Update the code to use a switch statement in place of the if-elseif-else construct */

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } 
// else if (product[0] == "02")
// {
//     type = "T-Shirt";
// }
// else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

// if (product[1] == "BL")
// {
//     color = "Black";
// }
// else if (product[1] == "MN")
// {
//     color = "Maroon";
// }
// else
// {
//     color = "White";
// }

switch(product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

// if (product[2] == "S")
// {
//     size = "Small";
// }
// else if (product[2] == "M")
// {
//     size = "Medium";
// }
// else if (product[2] == "L")
// {
//     size = "Large";
// }
// else 
// {
//     size = "One Size Fits All";
// }

switch(product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");




