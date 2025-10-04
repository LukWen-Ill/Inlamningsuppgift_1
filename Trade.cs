// namespace App;

using App;

class Trade
{
    public Item SenderItem;
    public Item RecieverItem;
    public int TradeStatus;


    // Konstruktor  
    public Trade(Item senderItem, Item recieverItem, int tradeStatus)
    {
        SenderItem = senderItem;
        RecieverItem = recieverItem;
        TradeStatus = tradeStatus;
    }
    // public int GetcompletedTrades()
    // {

    // }
    public void Get()
    {
        if (TradeStatus == 1) // check if pending, write "Status Pending"
        {
            Console.WriteLine("Status " + (Status)TradeStatus);
        }
        if (TradeStatus >= 1) // check if pending, write "Status Accepted"
        {
            Console.WriteLine("Status " + (Status)TradeStatus);
        }
        if (TradeStatus <= 1) // check if pending, write "Status Declined"
        {
            Console.WriteLine("Status " + (Status)TradeStatus);
        }

        Console.WriteLine("Sender: " + SenderItem.Owner.Email);
        Console.WriteLine("Reciever: " + RecieverItem.Owner.Email);
        Console.WriteLine("Items: \n1. " + SenderItem.Name + "\n2. " + RecieverItem.Name);

        Console.WriteLine("NÄSTA::::::_:_:_:_:_:_");
    }
    public static int ShowUsersTrades(User active_user, Item UsersItems, int count)
    {
        {
            if (active_user.Email == UsersItems.Owner.Email)
            {
                Console.Write(count + ". ");
                UsersItems.Get();
                count++;
            }
        }
        return count;
    }
    enum Status
    {
        Accepted,
        Pending,
        Declined,
    }
}