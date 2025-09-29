// namespace App;

using App;

class Trade
{
    public User Sender;
    public User Reciever;
    public Item Items;

    // Konstruktor  
    public Trade(User sender, User reciever, Item items)
    {
        Sender = sender;
        Reciever = reciever;
        Items = items;
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