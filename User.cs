namespace App;

class User  // Class/objekt "User"
{
    public string Email;
    string _password; //Private (kan endast läsas i klassen)

    // Konstruktor
    public User(string email, string password)
    {
        Email = email;
        _password = password;
    }

    // Return TRUE IF username && password is correct.
    public bool TryLogin(string email, string password)
    {
        return TryUsername(email) && password == _password;
    }
    public bool TryUsername(string input_username)
    {
        return input_username == Email;
    }
}

