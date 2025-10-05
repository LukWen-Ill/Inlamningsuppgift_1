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
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"{Owner.Email}");
        Console.ResetColor();

        Console.Write(" item: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{Name}");
        Console.ResetColor();
        Console.WriteLine($"   {Description}\n");
    }
    public static int ShowItems(User active_user, Item items, int count, bool usersItems)
    {
        if (!usersItems) // Shows all items EXCEPT the users
        {
            if (active_user.Email != items.Owner.Email)

            {
                Console.Write(count + ". ");
                items.Get();
                count++;
            }
        }
        else // Show ONLY the users items
        {
            if (active_user.Email == items.Owner.Email)
            {
                Console.Write(count + ". ");
                items.Get();
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
