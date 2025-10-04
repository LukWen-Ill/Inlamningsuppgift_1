// namespace App;

using App;

class Item
{
    public string Name;
    public string Description;
    public User Owner;

    // Konstruktor
    public Item(string name, string description, User owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }
    // public int GetitemsUploaded()
    // {

    // }
    // public int GetincomingRequests()
    // {

    // }
    public void Get()
    {
        Console.WriteLine($"{Name}\n   {Description}\n   Trader: {Owner.Email}\n");
    }
    public static int ShowItems(User active_user, Item items, int count, int choice)
    {
        if (choice == 1) // Shows all items except the users
        {
            if (active_user.Email != items.Owner.Email)

            {
                Console.Write(count + ". ");
                items.Get();
                count++;
            }
        }
        else if (choice == 2) // Show all the users items
        {
            if (active_user.Email == items.Owner.Email)
            {
                Console.Write(count + ". ");
                items.Get();
                count++;
            }
        }
        else if (choice == 3) // Shows all items including users
        {
            Console.Write(count + ". ");
            items.Get();
            count++;
        }
        else
        {
            count++;
        }
        return count;
    }
}

// A user needs to be able to upload information about the item they wish to trade.
// A user needs to be able to browse a list of other users items. item.get() + exception of exception list
// A user needs to be able to request a trade for other users items.
// A user needs to be able to browse trade requests.
// A user needs to be able to accept a trade request.
// A user needs to be able to deny a trade request.
// A user needs to be able to browse completed requests.
