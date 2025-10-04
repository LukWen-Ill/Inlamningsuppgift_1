namespace App;

class Menu
{
    public static void MainMenu(User? activeUser)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine("│                 MAIN MENU                │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();

        Console.WriteLine("1) Register Account");
        Console.WriteLine("2) Login");
        Console.WriteLine("0) Exit");
        Console.Write("\nSelect an option: ");
    }

    public static void DashboardOverview(int uploads, int requests, int completed)
    {
        // Fake stats - replace with real data later
        Console.WriteLine("Overview:");
        Console.WriteLine($"- Items uploaded: {uploads}");
        Console.WriteLine($"- Incoming requests: {requests}");
        Console.WriteLine($"- Completed trades: {completed}");
        Console.WriteLine();
    }
    public static void DashboardMenu(User activeUser)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine($"│   DASHBOARD - Logged in as {activeUser.Email.PadRight(14)}│");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();
        // int itemsUploaded = GetitemsUploaded(); // make these
        // int incomingRequests = GetincomingRequests();
        // int completedTrades = GetcompletedTrades();

        // DashboardOverview(itemsUploaded, incomingRequests, completedTrades);

        Console.WriteLine("1) Upload Item");
        Console.WriteLine("2) Browse Items");
        Console.WriteLine("3) Manage Trade Requests");
        Console.WriteLine("4) Logout");
        Console.WriteLine("0) Exit");
        Console.Write("\nSelect an option: ");
    }

    public static void ManageTradeRequests(User activeUser)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine("│            TRADE REQUEST MENU            │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();

        Console.WriteLine("1) Trades Sent");
        Console.WriteLine("2) Trades Received");
        Console.WriteLine("3) Trade History");
        Console.WriteLine("0) Back to Dashboard");
        Console.Write("\nSelect an option: ");
    }

    public static void ReceivedTradeMenu(User activeUser)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine("│          RECEIVED TRADE REQUESTS         │");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();

        Console.WriteLine("1) Accept Request");
        Console.WriteLine("2) Deny Request");
        Console.WriteLine("0) Back to Trade Requests");
        Console.Write("\nSelect an option: ");
    }

    public static void DrawHeaderBox(string input)
    {
        Console.Clear();
        Console.WriteLine("┌──────────────────────────────────────────┐");
        Console.WriteLine($"│          {input.PadRight(32)}│");
        Console.WriteLine("└──────────────────────────────────────────┘");
        Console.ResetColor();

    }
}
