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
using App;

//  Console.Clear med catch för debuggern
try { Console.Clear(); } catch { }

User testUser1 = new User("Havash", "1");
User testUser2 = new User("Therese", "1");
User testUser3 = new User("Lukas", "1");

// Uppstarts variabler
List<User> users = new List<User>(); //Skapar en lista med Users
List<Item> items = new List<Item>(); //Skapar en lista med Items
List<Trade> trades = new List<Trade>(); //Skapar en lista med Trades 

User? active_user = null;
Trade? active_trade = null;

bool main_meny_loop = true;
bool trade_system_loop = true;
bool trade_system_request_loop = true;


// Hårdkodade användare från test123
users.Add(testUser1);
users.Add(testUser2);
users.Add(testUser3);

// Hårdkodade ITEMS tillhörande TESTUSER 1 2 3
items.Add(new Item("Stol", "Grön färg, lite sliten.", testUser1));
items.Add(new Item("iPhone 13 Pro Max", "Sprucken skärm.", testUser2));
items.Add(new Item("Barnsäng", "90x90 i topp skick.", testUser3));




// Hårdkodade användare 
users.Add(new User("LUKAS", "LÖSENORD"));
users.Add(new User("max", "123"));



while (main_meny_loop)
{

    try { Console.Clear(); } catch { } // aktivera när felhanteringen är klar
    Console.WriteLine("---Trading System---");
    Console.WriteLine("");
    if (active_user != null) { Console.WriteLine("Logged in as: " + active_user.Email); } // Ternery
    Console.WriteLine("1. Create new Account");
    if (active_user == null) { Console.WriteLine("2. Login"); }
    else { Console.WriteLine("2. Trade"); }
    if (active_user != null) { Console.WriteLine("\nLogout"); }
    string input = Console.ReadLine();
    try { Console.Clear(); } catch { }
    switch (input)
    {
        case "1": // Register Account
            bool is_viable = true;
            try { Console.Clear(); } catch { }
            Console.WriteLine("---Trading System---");
            Console.WriteLine("");
            Console.WriteLine("---Create Account---");
            Console.Write("Please Enter Email: ");
            Console.WriteLine("");
            Console.WriteLine("cancel");
            string input_username = Console.ReadLine();
            if (input_username == "cancel")
            {
                break;
            }
            else
            {
                foreach (User user in users)//här testar vi alla users om användarnamnet är taget 
                {
                    if (user.TryUsername(input_username))
                    {
                        try { Console.Clear(); } catch { }
                        Console.WriteLine("---Trading System---");
                        Console.WriteLine("");
                        Console.WriteLine("---Create Account---");
                        Console.WriteLine("Username: " + input_username + " is already in use.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue .. ");
                        Console.ReadLine();
                        is_viable = false;
                        break;
                    }
                }
            }
            if (is_viable)
            {
                Console.Write("Please Enter Password: ");
                string input_password = Console.ReadLine();
                users.Add(new User(input_username, input_password));
                Console.WriteLine("\nA User Was Created Successfully");
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue .. ");
                Console.ReadLine();
                break;
            }
            break;
        case "2": // Login
            if (active_user == null) // Login visas i menyn
            {
                Console.WriteLine("---Trading System---");
                Console.WriteLine("");
                Console.WriteLine("---Log in---");
                Console.Write("Please Enter Email: ");
                string input_login_u = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                string input_login_p = Console.ReadLine();
                foreach (User user in users) //Try Login med input
                {
                    Console.WriteLine(user.TryLogin(input_login_u, input_login_p)); // ???
                    if (user.TryLogin(input_login_u, input_login_p))
                    {
                        active_user = user;
                        break;
                    }
                }
                if (active_user == null)
                {
                    try { Console.Clear(); } catch { }
                    Console.WriteLine("---Trading System---");
                    Console.WriteLine("");
                    Console.WriteLine("Invalid login details");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue .. ");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    try { Console.Clear(); } catch { }
                    Console.WriteLine("---Trading System---");
                    Console.WriteLine("");
                    Console.WriteLine("Login Successful");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue .. ");
                    Console.ReadLine();
                }
                break;
            }
            else //  Körs om active_user != null (INLOGGAD)
            {
                trade_system_loop = true;
                while (trade_system_loop)
                {
                    try { Console.Clear(); } catch { }
                    Console.WriteLine("---Trade System---");
                    Console.WriteLine("");
                    Console.WriteLine("Logged in as: " + active_user.Email);
                    Console.WriteLine("1. Browser Items"); // Show all items > Enter Index of Item > Send request 
                    Console.WriteLine("2. My Items"); // Show all items > Add/remove > (request this item)
                    Console.WriteLine("3. Requests"); // Show all requests > enter index of item wish to modify > Accept/deny If not pending  
                    Console.WriteLine("0. Previous Menu");

                    input = Console.ReadLine();
                    trade_system_request_loop = true;
                    while (trade_system_request_loop)
                    {
                        switch (input)
                        {
                            case "1": // view all items
                                try { Console.Clear(); } catch { }
                                Console.WriteLine("---Trade feed---");
                                Console.WriteLine("");
                                int item_index = 1;
                                foreach (Item item in items)
                                {
                                    Console.Write(item_index + ". ");
                                    item.Get();
                                    item_index++;
                                }
                                Console.WriteLine("");
                                Console.WriteLine("---Trade Menu---");
                                Console.WriteLine("1. Request Trade");
                                Console.WriteLine("2. Previous Menu");
                                string input_2 = Console.ReadLine();
                                switch (input_2)
                                {
                                    case "1": // request trade
                                              //vilket item vill du skicka en request om 
                                              // confirm
                                              // skicka request om trade
                                        Console.WriteLine("Enter # of Trade");
                                        input_2 = Console.ReadLine();
                                        int.TryParse(input, out int int_input);
                                        int count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)
                                        foreach (Item item in items)
                                        {
                                            if (count <= int_input)
                                            {
                                                string name_temp = item.Name; // sparar in variablerna från ITEM
                                                string description_temp = item.Description;
                                                User owner_temp = item.Owner;

                                                Item active_Trade_temp = new Item(name_temp, description_temp, owner_temp); //Hämtar och sparar Item informationen
                                                trades.Add(new Trade(active_user, owner_temp, active_Trade_temp)); // lägger till i en lista av aktiva trades
                                            }
                                        }
                                        break;
                                    case "2": // back to prev menu
                                        trade_system_request_loop = false;
                                        break;
                                }
                                break;
                            case "2": // kolla egna items
                                try { Console.Clear(); } catch { }
                                item_index = 1;
                                foreach (Item item in items)
                                {
                                    if (item.Owner == active_user)
                                    {
                                        Console.Write(item_index + ". ");
                                        item.Get();
                                        item_index++;
                                    }
                                }

                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                break;
                            case "3": // kolla trade requests (lista)
                                try { Console.Clear(); } catch { }
                                foreach (Trade trade in trades)
                                {
                                    trade.Get();
                                }
                                Console.WriteLine("---Trade Requests---");
                                Console.WriteLine("Logged in as: " + active_user.Email);
                                Console.WriteLine("1. Send trade"); // 
                                Console.WriteLine("2. View requests"); // 
                                Console.WriteLine("3. "); // Accept/deny/pending // browse
                                input = Console.ReadLine();
                                switch (input)
                                {

                                }
                                break;
                            case "0": // Stop loop, return to prev menu
                                trade_system_loop = false;
                                break;
                        }
                    }
                }
                break;
            }
        case "logout":
            active_user = null;
            break;
    }
}
// A user needs to be able to upload information about the item they wish to trade.
// A user needs to be able to browse a list of other users items. item.get() 
// A user needs to be able to request a trade for other users items.
// A user needs to be able to browse trade requests.
// A user needs to be able to accept a trade request.
// A user needs to be able to deny a trade request.
// A user needs to be able to browse completed requests.