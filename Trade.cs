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
    enum Status
    {
        Accepted,
        Pending,
        Declined,
    }

    // public Status A()
    // {
    //     return Status.Accepted;
    // }
    // public Status B()
    // {
    //     return Status.Declined;
    // }


    // public Status GetStatus(string sender, string reciever, string item)
    // {
    //     if () // IF RECIEVER has accepted ITEM of SENDER => Status is enum ACCEPTED
    //     Status = Accepted;
    //     else if () // IF RECIEVER not accepted ITEM of SENDER and if status is not DEClINED=> Status is enum PENDING
    //     Status = Pending;
    //     else () // IF RECIEVER has not accepted ITEM of SENDER and if statis is DECLINED (ELSE) => Status is enum DECLINED
    //     Status = Declined;
    //     return Status.Trade;
    // }
}