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
List<User> users = new List<User>(); //Skapar en lista med users från klassen User
List<Item> items = new List<Item>(); //Skapar en lista med users från klassen User
User? active_user = null;
bool running = true;

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



while (running)
{
    {
        try { Console.Clear(); } catch { } // aktivera när felhanteringen är klar
        Console.WriteLine("Welcome to Trade System");
        Console.WriteLine("Please ");
        Console.WriteLine("1. Create Account");
        if (active_user == null) { Console.WriteLine("2. Login"); }
        else { Console.WriteLine("2. Trade"); }
        if (active_user != null) { Console.WriteLine("Logout"); } // snygg men onödig 
        string input = Console.ReadLine();
        try { Console.Clear(); } catch { }
        switch (input)
        {
            case "1": // Register Account
                bool is_viable = true;
                try { Console.Clear(); } catch { }
                Console.WriteLine("--- Create Account ---");
                Console.Write("Please Enter Email: ");
                string input_username = Console.ReadLine();
                foreach (User user in users)//här testar vi alla users om användarnamnet är taget 
                {
                    if (user.TryUsername(input_username))
                    {
                        try { Console.Clear(); } catch { }
                        Console.WriteLine("Username: " + input_username + " is already in use.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue .. ");
                        Console.ReadLine();
                        is_viable = false;
                        break;
                    }
                }
                if (is_viable)
                {
                    Console.Write("Please Enter Password: ");
                    string input_password = Console.ReadLine();
                    users.Add(new User(input_username, input_password));
                    Console.WriteLine("A User Was Created Successfully");
                    foreach (User user in users)
                    {
                        user.Get();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue .. ");
                    Console.ReadLine();
                    break;
                }
                break;
            case "2": // Login
                if (active_user == null)
                {
                    //  Körs om active_user = null (EJ inloggad)
                    if (active_user == null)
                    {
                        Console.WriteLine("--- Log in ---");
                        Console.Write("Please Enter Email: ");
                        string input_login_u = Console.ReadLine();
                        Console.Write("Please Enter Password: ");
                        string input_login_p = Console.ReadLine();

                        //Try Login med input
                        foreach (User user in users)
                        {
                            Console.WriteLine(user.TryLogin(input_login_u, input_login_p));

                            if (user.TryLogin(input_login_u, input_login_p))
                            {
                                try { Console.Clear(); } catch { }
                                Console.WriteLine("Login Successful");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue .. ");
                                Console.ReadLine();
                                active_user = user;
                                break;
                            }

                        }
                        if (active_user == null)
                        {
                            try { Console.Clear(); } catch { }
                            Console.WriteLine("Invalid login details");
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue .. ");
                            Console.ReadLine();
                            break;
                        }
                        break;

                    }
                    else
                    {
                        try { Console.Clear(); } catch { }
                        Console.WriteLine("A user is already logged in");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue .. ");
                        Console.ReadLine();
                        break;
                    }
                }

                //  Körs om active_user = null (EJ inloggad)
                else
                {
                    Console.WriteLine("Welcome to Trade System");
                    Console.WriteLine("Logged in as: " + active_user.Email);
                    Console.WriteLine("1. All Items"); // 
                    Console.WriteLine("2. My Items"); // 
                    Console.WriteLine("3. Trade Requests"); // Accept/deny/pending // browse
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            // view alla items
                            foreach (Item item in items)
                            {
                                item.Get();
                                Console.WriteLine("");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue .. ");
                            Console.ReadLine();
                            break;
                        case "2":
                            // kolla egna items
                            int count = 1;
                            foreach (Item item in items)
                            {
                                if (item.Owner == active_user)
                                {
                                    Console.Write(count + ". ");
                                    item.Get();
                                    count++;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue .. ");
                            Console.ReadLine();
                            break;
                        case "3":
                            // kolla trade requests (lista)
                            Console.WriteLine("Trade Requests");
                            Console.WriteLine("Logged in as: " + active_user.Email);
                            Console.WriteLine("1. "); // 
                            Console.WriteLine("2. "); // 
                            Console.WriteLine("3. "); // Accept/deny/pending // browse
                            input = Console.ReadLine();
                            switch (input)
                            {

                            }
                            break;

                    }
                    break;
                }
            case "logout":
                active_user = null;
                break;
        }
    }
}
// A user needs to be able to upload information about the item they wish to trade.
// A user needs to be able to browse a list of other users items. item.get() + exception of exception list
// A user needs to be able to request a trade for other users items.
// A user needs to be able to browse trade requests.
// A user needs to be able to accept a trade request.
// A user needs to be able to deny a trade request.
// A user needs to be able to browse completed requests.