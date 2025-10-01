namespace App;

class Menu
{
    public static void MainMenu(User? active_user)
    {
        try { Console.Clear(); } catch { } // aktivera när felhanteringen är klar
        Console.WriteLine("---Trading System---");
        if (active_user != null) { Console.WriteLine("Logged in as: " + active_user.Email + "\n"); } // Ternery ?? 
        Console.WriteLine("1. Create new Account");
        if (active_user == null) { Console.WriteLine("2. Login"); }
        else { Console.WriteLine("2. Trade"); }
        if (active_user != null) { Console.WriteLine("\n3. Logout"); }
    }
}