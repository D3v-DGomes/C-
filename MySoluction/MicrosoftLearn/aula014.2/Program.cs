/* Methods with optional paramereters */

/*  
Create an RSVP App:

In this task, you will create a short app for guests to RSVP to an event. Guests will provide 
their party size and any allergies. You will also add the option to restrict RSVPs to a select 
guest list.
*/

string[] guestList = {"Rebecca", "Angela", "Eduarda", "Bárbara",};
string[] rsvps = new string[10];
int count = 0;

// Calling the method:
RSVP("Rebecca", 1, "none", true);
RSVP("Angela", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
RSVP("Eduarda", 4, "none", false);
RSVP("Bárbara", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) // optional parameters
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list.");
            return;
        }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}