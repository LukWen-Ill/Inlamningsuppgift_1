namespace App;

interface IUser // Return TRUE IF username && password is correct.
{
    public bool TryLogin(string username, string password);

}