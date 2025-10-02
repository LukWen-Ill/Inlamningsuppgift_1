namespace App;

class Menu
{
    public static void MainMenu(User? active_user)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Utils.ClearScreen();
        DrawHeaderBox("📈 MAIN MENU");
        Console.ForegroundColor = ConsoleColor.Green;

        if (active_user != null) { Console.Write($"│ Logged in as: "); } else { Console.WriteLine($"│ {"Not logged in".PadRight(40)}│"); }
        Console.ForegroundColor = ConsoleColor.Red;
        if (active_user != null) { Console.Write($"{active_user.Email.PadRight(27)}"); }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("│" + "\n" + "│                                          │");
        Console.WriteLine("│  1) Create Account                       │");
        if (active_user == null) { string tradeOrLogin = "Login"; Console.WriteLine($"│  2) {tradeOrLogin}                                │"); } else { string tradeOrLogin = "Trade"; Console.WriteLine($"│  2) {tradeOrLogin}                                │"); }
        Console.WriteLine("│  3) Logout                               │");
        Console.WriteLine("│  0) Exit                                 │");
        Console.WriteLine("│                                          │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();
        Console.Write("Select an option: ");
    }

    public static void TradeMenu(User? active_user)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Utils.ClearScreen();
        DrawHeaderBox("🤝 TRADE MENU");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("│ Logged in as:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {active_user.Email.PadRight(27)}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("│" + "\n" + "│                                          │");
        Console.WriteLine("│  1) Marketplace                          │");
        Console.WriteLine("│  2) My Items                             │");
        Console.WriteLine("│  3) Trade Requests                       │");
        Console.WriteLine("│  0) Back to Main Menu                    │");
        Console.WriteLine("│                                          │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();
        Console.Write("Select an option: ");
    }
    public static void ItemsMenu(User? active_user)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Utils.ClearScreen();
        DrawHeaderBox("📦 ITEMS MENU");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("│ Logged in as:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {active_user.Email.PadRight(27)}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("│" + "\n" + "│                                          │");
        Console.WriteLine("│  1) View Items in List                   │");
        Console.WriteLine("│  2) Create New Trade Request             │");
        Console.WriteLine("│  3) Trade Requests                       │");
        Console.WriteLine("│  0) Back to Trade Menu                   │");
        Console.WriteLine("│                                          │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();
        Console.Write("Select an option: ");
    }

    public static void DrawHeaderBox(string title)
    {
        // Trade Menu
        // List of Items
        // Trading System
        // Items Menu
        // New Account Creation
        // New Trade Creation
        // Logging In
        Utils.ClearScreen();

        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine($"│  {title.PadRight(40)}│");
        Console.WriteLine("└──────────────────────────────────────────┘");

        Console.ResetColor();
    }
}
