namespace App;

class Utils
{
    public static void ClearScreen()
    {
        try { Console.Clear(); } catch { }
    }
    public static void PressEnter()
    {
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue .. ");
        Console.ReadLine();
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

}