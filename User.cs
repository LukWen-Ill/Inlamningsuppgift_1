namespace App;

class User : IUser // Class User med Interface IUser
{
    public string Email;
    string _password; //Private (kan endast läsas i klassen)

    // Konstruktor
    public User (string email, string password)
    {
        Email = email;
        _password = password;
    }
    
    // Return TRUE IF username && password is correct.
    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

}