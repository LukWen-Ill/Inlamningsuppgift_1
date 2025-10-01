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

User? active_user = testUser3;
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
trades.Add(new Trade(item2, item3, 1)); // Pending
trades.Add(new Trade(item5, item6, 1)); // Pending
trades.Add(new Trade(item7, item8, 1)); // Pending
trades.Add(new Trade(item6, item1, 1)); // Pending
trades.Add(new Trade(item4, item5, 1)); // Pending
trades.Add(new Trade(item8, item7, 1)); // Pending



// Hårdkodade användare 
users.Add(new User("LUKAS", "LÖSENORD"));
users.Add(new User("max", "123"));



while (main_meny_loop)
{

    // foreach (Trade trade in trades)
    // {
    //     trade.Get();
    // }
    // Console.WriteLine("---TESTER---");
    // Console.WriteLine("Press Enter to Start Program...");
    // Console.ReadLine();



    try { Console.Clear(); } catch { } // aktivera när felhanteringen är klar

    Menu.MainMenu(active_user);

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
                    Console.WriteLine("");
                    Console.WriteLine("---cancel---");
                    input = "";
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1": // Broweser Items
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
                                if (active_user.Email != item.Owner.Email)
                                {
                                    Console.Write(item_index + ". ");
                                    item.Get();
                                    item_index++;
                                }
                            }
                            Console.WriteLine("---Trade Menu---");
                            Console.WriteLine("");
                            Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 

                            string input_index_of_item = "";
                            input_index_of_item = Console.ReadLine();

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
                                    Console.WriteLine("Selected item:" + recieverItem_temp.Name);

                                    Console.WriteLine("Description of item: " + recieverItem_temp.Description);
                                    Console.WriteLine("");
                                }
                                count++;
                            }
                            item_index = 1;
                            Console.WriteLine("Choose one of your items to trade\n");
                            foreach (Item item in items) // visar Lista på active users items (EGNA)
                            {
                                if (item.Owner.Email == active_user.Email)
                                {
                                    Console.Write(item_index + ". ");
                                    item.Get();
                                    item_index++;

                                }
                            }
                            Console.WriteLine("---Trade Menu---");
                            Console.WriteLine("");
                            Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 
                            string string_of_index_input = Console.ReadLine();

                            //KAN BLI METOD
                            int.TryParse(string_of_index_input, out int int_input_2);
                            count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)
                            foreach (Item item in items) //samma logic som för att hämta reciever
                            {
                                if (item.Owner.Email == active_user.Email)
                                {
                                    if (count == int_input_2) // har vilket index och listan filtreras MED active user 
                                    {
                                        senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner Senders item i en temp
                                        Console.WriteLine(active_user.Email + " item: " + senderItem_temp.Name);
                                        Console.WriteLine(senderItem_temp.Description);
                                        Console.WriteLine("");
                                    }
                                    count++;
                                }
                            }
                            //

                            try { Console.Clear(); } catch { }

                            if (senderItem_temp != null && recieverItem_temp != null)
                            {

                                Console.WriteLine($"Trade request successfully sent to {recieverItem_temp.Owner.Email}");
                                Console.WriteLine($"{recieverItem_temp.Owner.Email}: {recieverItem_temp.Name}");
                                Console.WriteLine($"Your offer: {senderItem_temp.Name}");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                trades.Add(new Trade(senderItem_temp, recieverItem_temp, 0));
                            }
                            else
                            {
                                Console.WriteLine("Trade request failed, please try again");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                break;
                            }
                            break;
                        // }
                        // foreach (Item item in items)
                        // {
                        //     if (item.Owner == active_user)
                        //     {
                        //         Item senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
                        //         Console.WriteLine("this is the senderItem_temp: ");
                        //         senderItem_temp.Get();
                        //     }
                        // }
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
                            Console.WriteLine("---Trade Menu---");
                            Console.WriteLine("");
                            Console.WriteLine("Enter # of item to request trade"); //vilket av DINA item vill du tradea  
                            Console.ReadLine();
                            break;
                        case "3": // kolla trade recieve
                            try { Console.Clear(); } catch { }

                            // Show() logged in users items
                            int item_index_count = 1;
                            foreach (Trade trade in trades)
                            {
                                if (trade.RecieverItem.Owner.Email == active_user.Email)
                                {
                                    Console.Write(item_index_count + ". ");
                                    trade.Get();
                                    item_index_count++;

                                }
                            }


                            item_index = 1;
                            Console.WriteLine("---Trade Menu---");
                            Console.WriteLine("");
                            Console.WriteLine("Enter # of item to request trade"); //vilket av DINA item vill du tradea
                            string string_of_index_input_p = Console.ReadLine();

                            //KAN BLI METOD
                            int.TryParse(string_of_index_input_p, out int int_input_2_p);
                            count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)

                            foreach (Item item in items) //Kollar vilket item som INDEX VALDE
                            {
                                if (item.Owner.Email == active_user.Email)
                                {
                                    if (count == int_input_2_p) // har vilket index och listan filtreras MED active user 
                                    {
                                        senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner Senders item i en temp
                                        Console.WriteLine(active_user.Email + " item: " + senderItem_temp.Name);
                                        Console.WriteLine(senderItem_temp.Description);
                                        Console.WriteLine("");
                                    }
                                    count++;
                                }
                            }


                            try { Console.Clear(); } catch { }
                            Console.WriteLine("---Trade Menu---");
                            Console.WriteLine("");
                            Console.WriteLine("Srkiv in vilken nummer");

                            string input_index_of_item_x = "";
                            input_index_of_item_x = Console.ReadLine();
                            int.TryParse(input_index_of_item_x, out int int_input_a);
                            count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)







                            foreach (Item item in items) // Skriver ut & hämtar värdet av vilket item som valdes
                            {
                                if (count == int_input_a && item.Owner.Email != active_user.Email) // har vilket index och listan filtreras utan active user 
                                {
                                    recieverItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
                                    Console.WriteLine("Selected item:" + recieverItem_temp.Name);

                                    Console.WriteLine("Description of item: " + recieverItem_temp.Description);
                                    Console.WriteLine("");
                                }
                                count++;
                            }


                            if (senderItem_temp != null && recieverItem_temp != null)
                            {

                                Console.WriteLine($"Trade request successfully sent to {recieverItem_temp.Owner.Email}");
                                Console.WriteLine($"{recieverItem_temp.Owner.Email}: {recieverItem_temp.Name}");
                                Console.WriteLine($"Your offer: {senderItem_temp.Name}");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                trades.Add(new Trade(senderItem_temp, recieverItem_temp, 0));
                            }
                            else
                            {
                                Console.WriteLine("Trade request failed, please try again");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                break;
                            }

                            break;
                        case "cancel": // Stop loop, return to prev menu
                            // trade_system_loop = false;
                            break;
                    }
                }
                break;
            }
        case "3":
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