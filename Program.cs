/*
    Betygskrav
        Ni ska ha arbetat aktivt med uppgiften
        Ni ska ha användt git aktivt under utvecklingsprocessen
        Ni ska dokumentera, med kommentarer i er kod, vad koden gör och varför ni
        gjort vissa val.
        Ni ska endast använda de koncept vi gått igenom hitils i kursen. Om ni undrar
        ifall ni får använda något annat, fråga utbildaren.
        Ni ska skriva, i en README.md fil, om hur man använder programmet och
        resonera kring era implementationsval. t.ex. varför ni användt eller inte
        användt komposition, inheritance, osv.
        Ni ska kunna svara på “Varför?” gällande er kod.

    Features
        A user needs to be able to register an account
        A user needs to be able to log in.
        A user needs to be able to log out.
*/
using System.Diagnostics;
using App;

//  Console.Clear med catch för debuggern
try { Console.Clear(); } catch { }

User testUser1 = new User("Havash", "1");
User testUser2 = new User("Therese", "1");
User testUser3 = new User("Lukas", "1");
User testUser4 = new User("Anna", "1234");
User testUser5 = new User("Erik", "password");
User testUser6 = new User("Maja", "qwerty");
User testUser7 = new User("Oskar", "letmein");
User testUser8 = new User("Sofia", "hemligt");
User testUser9 = new User("Jonas", "abc123");
User testUser10 = new User("Elin", "pw123");

// Uppstarts variabler
List<User> users = new List<User>(); //Skapar en lista med Users
List<Item> items = new List<Item>(); //Skapar en lista med Items
List<Trade> trades = new List<Trade>(); //Skapar en lista med Trades 




// Hårdkodade användare från test123
users.Add(testUser1);
users.Add(testUser2);
users.Add(testUser3);
users.Add(testUser4);
users.Add(testUser5);
users.Add(testUser6);
users.Add(testUser7);
users.Add(testUser8);
users.Add(testUser9);
users.Add(testUser10);

// Hårdkodade ITEMS tillhörande TESTUSER 1 2 3
items.Add(new Item("Stol", "Grön färg, lite sliten.", testUser1));
items.Add(new Item("iPhone 13 Pro Max", "Sprucken skärm.", testUser2));
items.Add(new Item("Barnsäng", "90x90 i topp skick.", testUser3));
items.Add(new Item("Soffa", "Mörkgrå, plats för tre personer.", testUser1));
items.Add(new Item("Gitarr", "Akustisk, några repor på baksidan.", testUser2));
items.Add(new Item("Cykel", "Röd mountainbike, fungerar bra.", testUser3));
items.Add(new Item("Bokhylla", "Vit, 5 hyllplan, lite gulnad med åren.", testUser1));
items.Add(new Item("TV", "Samsung 55 tum, fungerar men fjärrkontrollen saknas.", testUser2));
items.Add(new Item("Mikrovågsugn", "Vit, 700W, nästan som ny.", testUser1));
items.Add(new Item("Kaffebryggare", "Philips, glaset sprucket men fungerar.", testUser2));
items.Add(new Item("Matbord", "Ek, fyrkantigt, några märken på ytan.", testUser3));
items.Add(new Item("Golvlampa", "Modern stil, kromfärgad med tygskärm.", testUser1));


// Skapa lite test-items
Item item1 = new Item("Gitarr", "Akustisk gitarr, bra skick.", testUser1);
Item item2 = new Item("Cykel", "Blå mountainbike.", testUser2);
Item item3 = new Item("TV", "50 tum, fungerar bra.", testUser3);
Item item4 = new Item("Dator", "Gaming laptop.", testUser4);
Item item5 = new Item("Kamera", "Systemkamera, nästan ny.", testUser5);
Item item6 = new Item("Soffa", "Mörkgrå, plats för tre personer.", testUser6);
Item item7 = new Item("Bokhylla", "Vit, 5 hyllplan.", testUser7);
Item item8 = new Item("Telefon", "iPhone 12, liten spricka i skärmen.", testUser8);

// Skapa trades
trades.Add(new Trade(item1, item2, 1)); // Pending
trades.Add(new Trade(item3, item4, 0)); // Accepted
trades.Add(new Trade(item2, item3, 2)); // Declined
trades.Add(new Trade(item1, item2, 1)); // Pending
trades.Add(new Trade(item3, item4, 1)); // Pending
trades.Add(new Trade(item2, item3, 0)); // Accepted
trades.Add(new Trade(item5, item6, 2)); // Declined
trades.Add(new Trade(item7, item8, 1)); // Pending
trades.Add(new Trade(item6, item1, 0)); // Accepted
trades.Add(new Trade(item4, item5, 2)); // Declined
trades.Add(new Trade(item8, item7, 1)); // Pending

// Hårdkodade användare 
users.Add(new User("LUKAS", "LÖSENORD"));
users.Add(new User("max", "123"));

User? active_user = testUser3;
Trade? active_trade = null;
Item? recieverItem_temp = null;
Item? senderItem_temp = null;

bool mainMenu_loop = true;
bool dashboard_loop = true;
bool trade_system_request_loop = true;
string? input_password = null;
string? input_username = null;

while (mainMenu_loop) // MainMenu
{
    // Ifall active_user är null visas inloggning (Mainmenu)
    // Annars visas dashboard.
    if (active_user == null) // if == null => register account
    {
        Menu.MainMenu(active_user);
        string? input = null;
        input = Console.ReadLine();

        switch (input)
        {
            case "1": // Register Account // MainMenu
                bool is_viable = true;
                input_username = null;

                Console.ForegroundColor = ConsoleColor.Blue;
                Menu.DrawHeaderBox("New Account Creation");

                Console.Write("Please Enter Email: ");
                input_username = Console.ReadLine();

                foreach (User user in users)//här testar vi alla users om användarnamnet är taget 
                {
                    if (user.TryUsername(input_username))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Menu.DrawHeaderBox("New Account Creation: Failed");

                        Console.WriteLine($"Username: {input_username} is already in use.");

                        Utils.PressEnter();

                        is_viable = false; // är det taget kommer is_viable bli false
                        break; // Break loopen => testar vilkoret is_viable
                    }
                }
                if (is_viable)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Menu.DrawHeaderBox("New Account Creation");

                    Console.Write("Please Enter Password: ");
                    input_password = null;
                    input_password = Console.ReadLine();

                    users.Add(new User(input_username, input_password));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Menu.DrawHeaderBox("New Account Creation: Sucess");

                    Console.WriteLine("A User Was Created Successfully");

                    Utils.PressEnter();
                    break;
                }
                break;
            case "2": // Login // MainMenu
                Console.ForegroundColor = ConsoleColor.Blue;

                Menu.DrawHeaderBox("Sign In");

                Console.Write("Please Enter Email: ");
                input_username = null;
                input_username = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                input_password = null;
                input_password = Console.ReadLine();

                foreach (User user in users)
                {
                    if (user.TryLogin(input_username, input_password))
                    {
                        active_user = user;
                        break;
                    }
                }
                if (active_user == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Menu.DrawHeaderBox("Sign In: Failed");

                    Console.WriteLine("Invalid login details");

                    Utils.PressEnter();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Menu.DrawHeaderBox("Sign In: Completed");
                    Console.WriteLine("User logged in successfully");

                    Utils.PressEnter();
                }
                break;
            case "0": // Exit // MainMenu
                mainMenu_loop = false;
                break;
            default: // Default // MainMenu
                Console.WriteLine("Oops! That wasn't a valid option. Try again.");
                break;
        }
    }
    else // else != null => "Login"
         // Här är andra delen av mainMenu. Ifall det finns en active_user
         // kommer man få en Dashboard översikt och andra alternativ.
    {
        dashboard_loop = true;
        while (dashboard_loop) // ShowDashboard
        {
            Menu.DashboardMenu(active_user);
            string? input = null;
            input = Console.ReadLine();
            switch (input)
            {
                case "1": // Upload Item // ShowDashboard
                    /*
                    New(int variable Item)
                    */
                    break;
                case "2": // Browse Items // ShowDashboard
                    /*
                    ShowItems()
                    Switch Case 
                        1. Filter
                        2. Trade 
                        3. Back
                    */
                    break;
                case "3": // Manage Trade Requests // ShowDashboard
                    /*
                        Trade Request Menu
                        Switch Case 
                            1. Trades Sent  
                            2. Trades Recieved  
                            3. Trade History 
                            4. back
                    */
                    break;
                case "4": // Logout // ShowDashboard
                    active_user = null;
                    dashboard_loop = false;
                    break;
                case "0": // Exit // ShowDashboard
                    dashboard_loop = false;
                    mainMenu_loop = false;
                    break;
                default: // Default // ShowDashboard
                    Console.WriteLine("Oops! That wasn't a valid option. Try again.");
                    break;
            }
        }
    }
}
// public int GetitemsUploaded()
// {

// }
// public int GetincomingRequests()
// {

// }
// public int GetcompletedTrades()
// {

// }
