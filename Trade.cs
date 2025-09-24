namespace App;

class Trade
{
    public string Sender;
    public string Reciever;
    public string Items;

    // Konstruktor  
    public Trade (string sender, string reciever, string items)
    {
        Sender = sender;
        Reciever = reciever;
        Items = items;
    }
}