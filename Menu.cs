namespace App;

class Menu
{
    public static void MainMenu(User? active_user)
    {
        Utils.ClearScreen();
        Banner();
        Console.WriteLine();
        if (active_user != null) { Console.WriteLine("Logged in as: " + active_user.Email + "\n"); }
        Console.WriteLine(" 1) Create Account");
        if (active_user == null) { Console.WriteLine(" 2) Login"); }
        else { Console.WriteLine(" 2) Trade"); }
        if (active_user != null) { Console.WriteLine(" 3) Logout"); }
        Console.WriteLine(" 0) Exit");
        Console.WriteLine();
    }
    public static void TradeMenu(User? active_user)
    {
        Utils.ClearScreen();
        Banner();
        Console.WriteLine();
        Console.WriteLine("Logged in as: " + active_user.Email + "\n");
        Console.WriteLine(" 1) Browser Items");
        Console.WriteLine(" 2) My Items");
        Console.WriteLine(" 3) Requests");
        Console.WriteLine(" 0) Exit");
        Console.WriteLine();
    }
    public static void Banner()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================================");
        Console.WriteLine("           📈 Trading System           ");
        Console.WriteLine("=======================================");
        Console.ResetColor();
    }
    public static void Exit()
    {
        Console.WriteLine(" 0) Exit");
        Console.WriteLine();
    }
}
