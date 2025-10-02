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
    public void Get()
    {
        Console.WriteLine($"{Name}\n   {Description}\n   Trader: {Owner.Email}\n");
    }
    public static int ShowOthersItems(User active_user, Item OthersItems, int count)
    {
        {
            if (active_user.Email != OthersItems.Owner.Email)
            {
                Console.Write(count + ". ");
                OthersItems.Get();
                count++;
            }
        }
        return count;
    }
    public static int ShowUsersItems(User active_user, Item UsersItems, int count)
    {
        {
            if (active_user.Email == UsersItems.Owner.Email)
            {
                Console.Write(count + ". ");
                UsersItems.Get();
                count++;
            }
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
