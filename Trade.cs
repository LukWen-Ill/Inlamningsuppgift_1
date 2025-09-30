// namespace App;

using App;

class Trade
{
    public User SenderName;
    public User RecieverName;
    public Item SenderItem;
    public Item RecieverItem;

    // Konstruktor  
    public Trade(Item senderItem, Item recieverItem)
    {
        SenderItem = senderItem;
        RecieverItem = recieverItem;
    }

    public void Get()
    {
        Console.WriteLine("Sender: " + SenderItem.Owner);
        Console.WriteLine("Reciever: " + RecieverItem.Owner);
        Console.WriteLine("Items: \n1. " + SenderItem.Name + "\n2. " + RecieverItem.Name);
    }


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