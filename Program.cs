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
Item? recieverItem_temp = null;
Item? senderItem_temp = null;

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
items.Add(new Item("Soffa", "Mörkgrå, plats för tre personer.", testUser1));
items.Add(new Item("Gitarr", "Akustisk, några repor på baksidan.", testUser2));
items.Add(new Item("Cykel", "Röd mountainbike, fungerar bra.", testUser3));
items.Add(new Item("Bokhylla", "Vit, 5 hyllplan, lite gulnad med åren.", testUser1));
items.Add(new Item("TV", "Samsung 55 tum, fungerar men fjärrkontrollen saknas.", testUser2));
items.Add(new Item("Mikrovågsugn", "Vit, 700W, nästan som ny.", testUser1));
items.Add(new Item("Kaffebryggare", "Philips, glaset sprucket men fungerar.", testUser2));
items.Add(new Item("Matbord", "Ek, fyrkantigt, några märken på ytan.", testUser3));
items.Add(new Item("Golvlampa", "Modern stil, kromfärgad med tygskärm.", testUser1));


foreach (Item item in items)
{
    Console.WriteLine(item.Name);
}

// Hårdkodade användare 
users.Add(new User("LUKAS", "LÖSENORD"));
users.Add(new User("max", "123"));



while (main_meny_loop)
{

    try { Console.Clear(); } catch { } // aktivera när felhanteringen är klar
    Console.WriteLine("---Trading System---");
    if (active_user != null) { Console.WriteLine("Logged in as: " + active_user.Email); } // Ternery
    Console.WriteLine("");
    Console.WriteLine("1. Create new Account");
    if (active_user == null) { Console.WriteLine("2. Login"); }
    else { Console.WriteLine("2. Trade"); }
    if (active_user != null) { Console.WriteLine("\nLogout"); }
    string input = "";
    input = Console.ReadLine();
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
            Console.WriteLine("---cancel---");
            string input_username = "";
            input_username = Console.ReadLine();
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
                string input_password = "";
                input_password = Console.ReadLine();
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
                string input_login_u = "";
                input_login_u = Console.ReadLine();
                Console.Write("Please Enter Password: ");
                string input_login_p = "";
                input_login_p = Console.ReadLine();
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
                    Console.WriteLine("Logged in as: " + active_user.Email);
                    Console.WriteLine("");
                    Console.WriteLine("1. Browser Items"); // Show all items > Enter Index of Item > Send request 
                    Console.WriteLine("2. My Items"); // Show all items > Add/remove > (request this item)
                    Console.WriteLine("3. Requests"); // Show all requests > enter index of item wish to modify > Accept/deny If not pending  
                    Console.WriteLine("---cancel---");

                    trade_system_request_loop = true;
                    while (trade_system_request_loop)
                    {
                        input = "";
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1": // view all items
                                try { Console.Clear(); } catch { }
                                int item_index = 1;
                                // int page_number = 1;
                                // int items_per_page = 10; // hur många objekt per sida
                                foreach (Item item in items)
                                {
                                    // if (item_index == (items_per_page * 10)) //Början till en visa endast såhär många per sida
                                    // {
                                    //     Console.WriteLine("");
                                    //     Console.WriteLine("---Trade Menu---");
                                    // Console.WriteLine("Press ENTER for next page ..");
                                    // Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 
                                    // Console.WriteLine("---cancel---");
                                    // string input_index_item = "";
                                    // input_index_item = Console.ReadLine();
                                    // if (input_index_item == "cancel")
                                    // {
                                    //     break;
                                    // }
                                    // page_number++; // turning page 
                                    // try { Console.Clear(); } catch { }
                                    // }
                                    Console.Write(item_index + ". ");
                                    item.Get();
                                    item_index++;
                                }
                                Console.WriteLine("---Trade Menu---");
                                Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 
                                Console.WriteLine("---cancel---");

                                string input_index_of_item = "";
                                input_index_of_item = Console.ReadLine();
                                if (input_index_of_item == "cancel")
                                {
                                    break;
                                }
                                else
                                {
                                    try { Console.Clear(); } catch { }
                                    Console.WriteLine("---Trade Menu---");
                                    Console.WriteLine("");
                                    int.TryParse(input_index_of_item, out int int_input);
                                    int count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)
                                    foreach (Item item in items) // Skriver ut & hämtar värdet av vilket item som valdes
                                    {
                                        if (count == int_input && item.Owner.Email != active_user.Email) // har vilket index och listan filtreras utan active user 
                                        {
                                            recieverItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
                                            Console.WriteLine("Selected item: " + recieverItem_temp.Name);
                                            Console.WriteLine(recieverItem_temp.Description);
                                            Console.WriteLine("");
                                        }
                                        count++;
                                    }
                                    item_index = 1;
                                    foreach (Item item in items) // visar Lista på active users items
                                    {
                                        if (item.Owner.Email == active_user.Email)
                                        {
                                            Console.Write(item_index + ". ");
                                            item.Get();
                                            item_index++;

                                        }

                                    }
                                    Console.WriteLine("---Trade Menu---");
                                    Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 
                                    Console.WriteLine("---cancel---");
                                }
                                break;

                                foreach (Item item in items)
                                {
                                    if (item.Owner == active_user)
                                    {
                                        Item senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
                                        Console.WriteLine("this is the senderItem_temp: ");
                                        senderItem_temp.Get();
                                    }
                                }
                            // trades.Add(new Trade("")); // lägger till i en lista av aktiva trades
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
                                input = "";
                                input = Console.ReadLine();
                                switch (input)
                                {

                                }
                                break;
                            case "cancel": // Stop loop, return to prev menu
                                // trade_system_loop = false;
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