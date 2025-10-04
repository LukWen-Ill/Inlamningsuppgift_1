// /*
//     Betygskrav
//         Ni ska ha arbetat aktivt med uppgiften
//         Ni ska ha användt git aktivt under utvecklingsprocessen
//         Ni ska dokumentera, med kommentarer i er kod, vad koden gör och varför ni
//         gjort vissa val.
//         Ni ska endast använda de koncept vi gått igenom hitils i kursen. Om ni undrar
//         ifall ni får använda något annat, fråga utbildaren.
//         Ni ska skriva, i en README.md fil, om hur man använder programmet och
//         resonera kring era implementationsval. t.ex. varför ni användt eller inte
//         användt komposition, inheritance, osv.
//         Ni ska kunna svara på “Varför?” gällande er kod.

//     Features
//         A user needs to be able to register an account
//         A user needs to be able to log in.
//         A user needs to be able to log out.
// */
// using System.Diagnostics;


// //  Console.Clear med catch för debuggern
// try { Console.Clear(); } catch { }

// User testUser1 = new User("Havash", "1");
// User testUser2 = new User("Therese", "1");
// User testUser3 = new User("Lukas", "1");
// User testUser4 = new User("Anna", "1234");
// User testUser5 = new User("Erik", "password");
// User testUser6 = new User("Maja", "qwerty");
// User testUser7 = new User("Oskar", "letmein");
// User testUser8 = new User("Sofia", "hemligt");
// User testUser9 = new User("Jonas", "abc123");
// User testUser10 = new User("Elin", "pw123");

// // Uppstarts variabler
// List<User> users = new List<User>(); //Skapar en lista med Users
// List<Item> items = new List<Item>(); //Skapar en lista med Items
// List<Trade> trades = new List<Trade>(); //Skapar en lista med Trades 

// User? active_user = testUser3;
// Trade? active_trade = null;
// Item? recieverItem_temp = null;
// Item? senderItem_temp = null;

// bool main_meny_loop = true;
// bool trade_system_loop = true;
// bool trade_system_request_loop = true;


// // Hårdkodade användare från test123
// users.Add(testUser1);
// users.Add(testUser2);
// users.Add(testUser3);
// users.Add(testUser4);
// users.Add(testUser5);
// users.Add(testUser6);
// users.Add(testUser7);
// users.Add(testUser8);
// users.Add(testUser9);
// users.Add(testUser10);

// // Hårdkodade ITEMS tillhörande TESTUSER 1 2 3
// items.Add(new Item("Stol", "Grön färg, lite sliten.", testUser1));
// items.Add(new Item("iPhone 13 Pro Max", "Sprucken skärm.", testUser2));
// items.Add(new Item("Barnsäng", "90x90 i topp skick.", testUser3));
// items.Add(new Item("Soffa", "Mörkgrå, plats för tre personer.", testUser1));
// items.Add(new Item("Gitarr", "Akustisk, några repor på baksidan.", testUser2));
// items.Add(new Item("Cykel", "Röd mountainbike, fungerar bra.", testUser3));
// items.Add(new Item("Bokhylla", "Vit, 5 hyllplan, lite gulnad med åren.", testUser1));
// items.Add(new Item("TV", "Samsung 55 tum, fungerar men fjärrkontrollen saknas.", testUser2));
// items.Add(new Item("Mikrovågsugn", "Vit, 700W, nästan som ny.", testUser1));
// items.Add(new Item("Kaffebryggare", "Philips, glaset sprucket men fungerar.", testUser2));
// items.Add(new Item("Matbord", "Ek, fyrkantigt, några märken på ytan.", testUser3));
// items.Add(new Item("Golvlampa", "Modern stil, kromfärgad med tygskärm.", testUser1));


// // Skapa lite test-items
// Item item1 = new Item("Gitarr", "Akustisk gitarr, bra skick.", testUser1);
// Item item2 = new Item("Cykel", "Blå mountainbike.", testUser2);
// Item item3 = new Item("TV", "50 tum, fungerar bra.", testUser3);
// Item item4 = new Item("Dator", "Gaming laptop.", testUser4);
// Item item5 = new Item("Kamera", "Systemkamera, nästan ny.", testUser5);
// Item item6 = new Item("Soffa", "Mörkgrå, plats för tre personer.", testUser6);
// Item item7 = new Item("Bokhylla", "Vit, 5 hyllplan.", testUser7);
// Item item8 = new Item("Telefon", "iPhone 12, liten spricka i skärmen.", testUser8);

// // Skapa trades
// trades.Add(new Trade(item1, item2, 1)); // Pending
// trades.Add(new Trade(item3, item4, 0)); // Accepted
// trades.Add(new Trade(item2, item3, 2)); // Declined
// trades.Add(new Trade(item1, item2, 1)); // Pending
// trades.Add(new Trade(item3, item4, 1)); // Pending
// trades.Add(new Trade(item2, item3, 0)); // Accepted
// trades.Add(new Trade(item5, item6, 2)); // Declined
// trades.Add(new Trade(item7, item8, 1)); // Pending
// trades.Add(new Trade(item6, item1, 0)); // Accepted
// trades.Add(new Trade(item4, item5, 2)); // Declined
// trades.Add(new Trade(item8, item7, 1)); // Pending

// // Hårdkodade användare 
// users.Add(new User("LUKAS", "LÖSENORD"));
// users.Add(new User("max", "123"));

// // Öppnar filen för läsning, using säkerställer att den stängs
// using (StreamReader reader = new StreamReader("items_data.txt"))
// {
//     // Variabel för att lagra varje rad
//     string rad;
//     // Läser en rad, fortsätter tills det inte finns fler rader (null)
//     while ((rad = reader.ReadLine()) != null)
//     {
//         // Skriver ut den aktuella raden
//         Console.WriteLine(rad);
//     }
//     // Filen stängs automatiskt här tack vare using
// }

// // using (StreamWriter writer = new StreamWriter("users_data.txt"))
// // {
// //     foreach (User user in users)
// //     {
// //         writer.Write($"{user.Email} ");
// //         writer.WriteLine($"{user._password} ");
// //     }
// // }



// Utils.ClearScreen();
// Menu.MainMenu(active_user);
// Menu.TradingMenu(active_user);
// Menu.ItemsMenu(active_user);

// while (main_meny_loop)
// {
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Menu.MainMenu(active_user);
//     string? input = null;
//     input = Console.ReadLine();
//     Utils.ClearScreen();

//     switch (input) // Main Menu
//     {
//         case "1": // Main Menu // Register Account
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Menu.DrawHeaderBox("New Account Creation");

//             Console.Write("Please Enter Email: ");
//             string? input_username = null;
//             input_username = Console.ReadLine();
//             bool is_viable = true;
//             foreach (User user in users)//här testar vi alla users om användarnamnet är taget 
//             {
//                 if (user.TryUsername(input_username))
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;

//                     Menu.DrawHeaderBox("New Account Creation: Failed");
//                     Console.WriteLine($"Username: {input_username} is already in use.");
//                     Utils.PressEnter();
//                     is_viable = false;
//                     break;
//                 }
//             }
//             if (is_viable)
//             {
//                 Console.ForegroundColor = ConsoleColor.Green;

//                 Menu.DrawHeaderBox("New Account Creation");
//                 Console.Write("Please Enter Password: ");
//                 string? input_password = null;
//                 input_password = Console.ReadLine();
//                 users.Add(new User(input_username, input_password));

//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Menu.DrawHeaderBox("New Account Creation: Sucess");

//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine("\nA User Was Created Successfully");
//                 Utils.PressEnter();
//                 break;
//             }
//             break;
//         case "2": // Main Menu // Login OR Trade
//             if (active_user == null) // if (true) { show login } else { show Trade } 
//             {
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Menu.DrawHeaderBox("Logging In");

//                 Console.Write("Please Enter Email: ");
//                 input_username = null;
//                 input_username = Console.ReadLine();
//                 Console.Write("Please Enter Password: ");
//                 string? input_password = null;
//                 input_password = Console.ReadLine();

//                 foreach (User user in users)
//                 {
//                     Console.WriteLine(user.TryLogin(input_username, input_password));
//                     if (user.TryLogin(input_username, input_password))
//                     {
//                         active_user = user;
//                         break;
//                     }
//                 }
//                 if (active_user == null)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Menu.DrawHeaderBox("Logging In: Failed");

//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("Invalid login details");

//                     Utils.PressEnter();
//                     break;
//                 }
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Menu.DrawHeaderBox("Logging In: Sucess");
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.WriteLine("Login Successful");

//                     Utils.PressEnter();
//                     break;
//                 }
//             }
//             //          (" 2) Trade");
//             else // IF true => show Login 
//                  // else => show Trade 
//             {
//                 trade_system_loop = true;
//                 while (trade_system_loop)
//                 {
//                     Menu.TradingMenu(active_user);
//                     input = null;
//                     input = Console.ReadLine();
//                     switch (input) // TradeMenu
//                     {
//                         case "1": // TradeMenu // All Items & Trades
//                             Menu.DrawHeaderBox("Trade Menu");
//                             Menu.ItemsMenu(active_user);
//                             input = null;
//                             input = Console.ReadLine();
//                             switch (input) // ItemsMenu
//                             {
//                                 case "1": // ItemsMenu // View Items in List
//                                     Menu.DrawHeaderBox("List of Items");
//                                     int item_index = 1;
//                                     foreach (Item item in items) // visar Lista på active users items (EGNA)
//                                     {
//                                         item_index = Item.ShowUsersItems(active_user, item, item_index);
//                                     }
//                                     Utils.PressEnter();
//                                     break;
//                                 case "2": // ItemsMenu // Create New Trade Request
//                                     Menu.DrawHeaderBox("New Trade Creation");
//                                     item_index = 1;
//                                     foreach (Item item in items)
//                                     {
//                                         item_index = Item.ShowOthersItems(active_user, item, item_index);
//                                     }
//                                     Console.WriteLine("Enter # of item to request trade");
//                                     Console.Write("Select an option: ");
//                                     string? string_index_input = null;
//                                     string_index_input = Console.ReadLine();
//                                     int.TryParse(string_index_input, out int int_index_input);
//                                     int count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)
//                                     Menu.DrawHeaderBox("List of Items");
//                                     foreach (Item item in items) // Skriver ut & hämtar värdet av vilket item som valdes
//                                     {
//                                         if (count == int_index_input && item.Owner.Email != active_user.Email) // har vilket index och listan filtreras utan active user 
//                                         {
//                                             recieverItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
//                                             Console.Write("   ");
//                                             recieverItem_temp.Get();
//                                         }
//                                         count++;
//                                     }
//                                     //
//                                     item_index = 1;
//                                     foreach (Item item in items) // visar Lista på active users items (EGNA)
//                                     {
//                                         item_index = Item.ShowUsersItems(active_user, item, item_index);
//                                     }

//                                     Console.WriteLine("---Trade Menu---");
//                                     Console.WriteLine("");
//                                     Console.WriteLine("Enter # of item to request trade"); //vilket item vill du skicka en request om 
//                                     string string_of_index_input = Console.ReadLine();

//                                     //KAN BLI METOD // VAD GÖR DEN ENS?
//                                     int.TryParse(string_of_index_input, out int int_input_2);
//                                     count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)
//                                     foreach (Item item in items) //samma logic som för att hämta reciever
//                                     {
//                                         if (item.Owner.Email == active_user.Email)
//                                         {
//                                             if (count == int_input_2) // har vilket index och listan filtreras MED active user 
//                                             {
//                                                 senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner Senders item i en temp
//                                                 Console.WriteLine(active_user.Email + " item: " + senderItem_temp.Name);
//                                                 Console.WriteLine(senderItem_temp.Description);
//                                                 Console.WriteLine("");
//                                             }
//                                             count++;
//                                         }
//                                     }
//                                     Utils.ClearScreen();
//                                     if (senderItem_temp != null && recieverItem_temp != null)
//                                     {
//                                         Menu.DrawHeaderBox("Trading System");
//                                         Console.WriteLine($"Trade request successfully sent to {recieverItem_temp.Owner.Email}");
//                                         Console.WriteLine($"{recieverItem_temp.Owner.Email}: {recieverItem_temp.Name}");
//                                         Console.WriteLine($"Your offer: {senderItem_temp.Name}");
//                                         Console.WriteLine();
//                                         Console.WriteLine("Press ENTER to continue .. ");
//                                         Console.ReadLine();
//                                         trades.Add(new Trade(senderItem_temp, recieverItem_temp, 0));
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("Trade request failed, please try again");
//                                         Console.WriteLine();
//                                         Console.WriteLine("Press ENTER to continue .. ");
//                                         Console.ReadLine();
//                                     }
//                                     break;
//                                 case "3": // TradeMenu / My Items & Trades
//                                     while (trade_system_loop)
//                                     {
//                                         Utils.ClearScreen();
//                                         Menu.DrawHeaderBox("Items Menu");
//                                         Menu.ItemsMenu(active_user);
//                                         input = null;
//                                         input = Console.ReadLine();
//                                         switch (input) // ItemsMenu
//                                         {
//                                             case "1": // ItemsMenu / View Items in List
//                                                 Utils.ClearScreen();
//                                                 // kolla egna items 
//                                                 Menu.DrawHeaderBox("List of Items");
//                                                 item_index = 1;
//                                                 foreach (Item item in items) // visar Lista på active users items (EGNA)
//                                                 {
//                                                     item_index = Item.ShowUsersItems(active_user, item, item_index);
//                                                 }
//                                                 Utils.PressEnter();
//                                                 break;
//                                             case "2": // ItemsMenu / Create new Trade Request
//                                                 break;
//                                             case "3": // ItemsMenu / Trade Requests
//                                                 break;
//                                             case "0": // Exit
//                                                 trade_system_loop = false;
//                                                 break;
//                                         }
//                                     }
//                                     break;
//                                 case "4": // TradeMenu / Trade Requests
//                                     try { Console.Clear(); } catch { }
//                                     // Show() logged in users items
//                                     int item_index_count = 1;
//                                     foreach (Trade trade in trades)
//                                     {
//                                         if (trade.RecieverItem.Owner.Email == active_user.Email)
//                                         {
//                                             Console.Write(item_index_count + ". ");
//                                             trade.Get();
//                                             item_index_count++;

//                                         }
//                                     }


//                                     item_index = 1;
//                                     Console.WriteLine("---Trade Menu---");
//                                     Console.WriteLine("");
//                                     Console.WriteLine("Enter # of item to request trade"); //vilket av DINA item vill du tradea
//                                     string string_of_index_input_p = Console.ReadLine();

//                                     //KAN BLI METOD
//                                     int.TryParse(string_of_index_input_p, out int int_input_2_p);
//                                     count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)

//                                     foreach (Item item in items) //Kollar vilket item som INDEX VALDE
//                                     {
//                                         if (item.Owner.Email == active_user.Email)
//                                         {
//                                             if (count == int_input_2_p) // har vilket index och listan filtreras MED active user 
//                                             {
//                                                 senderItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner Senders item i en temp
//                                                 Console.WriteLine(active_user.Email + " item: " + senderItem_temp.Name);
//                                                 Console.WriteLine(senderItem_temp.Description);
//                                                 Console.WriteLine("");
//                                             }
//                                             count++;
//                                         }
//                                     }


//                                     try { Console.Clear(); } catch { }
//                                     Console.WriteLine("---Trade Menu---");
//                                     Console.WriteLine("");
//                                     Console.WriteLine("Srkiv in vilken nummer");

//                                     string input_index_of_item_x = "";
//                                     input_index_of_item_x = Console.ReadLine();
//                                     int.TryParse(input_index_of_item_x, out int int_input_a);
//                                     count = 1; //räknare för att få fram vilket index som trade ligger på ( Istället för Metoden IndexOf)







//                                     foreach (Item item in items) // Skriver ut & hämtar värdet av vilket item som valdes
//                                     {
//                                         if (count == int_input_a && item.Owner.Email != active_user.Email) // har vilket index och listan filtreras utan active user 
//                                         {
//                                             recieverItem_temp = new Item(item.Name, item.Description, item.Owner); // sparar ner reciever (of Trade's) item i en temp // eller det item som du vill byta med
//                                             Console.WriteLine("Selected item:" + recieverItem_temp.Name);

//                                             Console.WriteLine("Description of item: " + recieverItem_temp.Description);
//                                             Console.WriteLine("");
//                                         }
//                                         count++;
//                                     }


//                                     if (senderItem_temp != null && recieverItem_temp != null)
//                                     {

//                                         Console.WriteLine($"Trade request successfully sent to {recieverItem_temp.Owner.Email}");
//                                         Console.WriteLine($"{recieverItem_temp.Owner.Email}: {recieverItem_temp.Name}");
//                                         Console.WriteLine($"Your offer: {senderItem_temp.Name}");
//                                         Console.WriteLine();
//                                         Console.WriteLine("Press ENTER to continue .. ");
//                                         Console.ReadLine();
//                                         trades.Add(new Trade(senderItem_temp, recieverItem_temp, 0));
//                                     }
//                                     else
//                                     {
//                                         Console.WriteLine("Trade request failed, please try again");
//                                         Console.WriteLine();
//                                         Console.WriteLine("Press ENTER to continue .. ");
//                                         Console.ReadLine();
//                                         break;
//                                     }

//                                     break;
//                                 case "0": // Stop loop, return to prev menu
//                                     trade_system_loop = false;
//                                     break;
//                             } // ItemsMenu
//                             break;
//                     } // TradeMenu
//                     break;
//                 } // While (trade_system_loop)
//                 break;
//             }
//         case "3": // Main Menu
//             active_user = null;
//             break;
//     }
// }
// // A user needs to be able to upload information about the item they wish to trade.
// // A user needs to be able to browse a list of other users items. item.get() 
// // A user needs to be able to request a trade for other users items.
// // A user needs to be able to browse trade requests.
// // A user needs to be able to accept a trade request.
// // A user needs to be able to deny a trade request.
// // A user needs to be able to browse completed requests.
