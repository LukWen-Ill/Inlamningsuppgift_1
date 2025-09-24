namespace App;

interface ITradeStatus
{
    public Status GetStatus(); //Hämtar Status på Trade

}

enum Status
{
    Pending,
    Accepted,
    Declined,
}