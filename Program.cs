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
        A user needs to be able to upload information about the item they wish to trade.
        A user needs to be able to browse a list of other users items.
        A user needs to be able to request a trade for other users items.
        A user needs to be able to browse trade requests.
        A user needs to be able to accept a trade request.
        A user needs to be able to deny a trade request.
        A user needs to be able to browse completed requests.
*/
using App;

//  Console.Clear med catch för debuggern
try { Console.Clear(); } catch { }

//Uppstarts variabler
List<User> users = new List<User>(); //Skapar en lista med users från klassen User
User? active_user = null;
bool running = true;
// string input_username;
// string input_password;

// Hårdkodade användare 
users.Add(new User("LUKAS", "LÖSENORD"));
users.Add(new User("Max", "123"));






while (running)
{

    Console.WriteLine("Welcome to TRADE SYSTEM");
    Console.WriteLine("Login or Create Account");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Create Account");
    string input = Console.ReadLine();
    try { Console.Clear(); } catch { }
    switch (input)
    {
        case "1": // Login
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
                    if (user.TryLogin(input_login_u, input_login_p))
                    {
                        try { Console.Clear(); } catch { }
                        Console.WriteLine(user.TryLogin(input_login_u, input_login_p));
                        Console.WriteLine("Login Successful");

                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue .. ");
                        Console.ReadLine();
                        try { Console.Clear(); } catch { }


                        active_user = user;
                        break;
                    }
                    else
                    {
                        try { Console.Clear(); } catch { }

                        Console.WriteLine("Invalid login details");

                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue .. ");
                        Console.ReadLine();

                        break;
                    }
                }
                break;
            }
            //  Annars:
            else
            {
                Console.WriteLine("A user is already logged in");

                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue .. ");
                Console.ReadLine();
                break;
            }

        case "2": // Register Account
                  //  
            Console.WriteLine("--- Create Account ---");
            Console.Write("Please Enter Email: ");
            string input_username = Console.ReadLine();
            Console.Write("Please Enter Password: ");
            string input_password = Console.ReadLine();

            foreach (User user in users)
            {
                if (!user.TryUsername(input_username))
                {
                    users.Add(new User(input_username, input_password));
                    Console.WriteLine("A User Was Created Successfully");

                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue .. ");
                    Console.ReadLine();

                    active_user = user;
                    break;
                }
                else
                {
                    Console.WriteLine("ANVÄNDARNAMN TAGET");
                    break;

                }
            }
            break;
    }


    // VISAR ANVÄNDARE FELHANTERING
    Console.WriteLine("-    FELHANTERAR");
    foreach (User user in users)
    {
        user.Get();
        // TRYLOGING FUNKTION 
        // Console.WriteLine(users.TryLogin("LUKAS", "LÖSENORD"));
        // Console.WriteLine(users.TryLogin("LUKAS", "lösenord"));
    }
}