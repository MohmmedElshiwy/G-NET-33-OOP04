namespace G_NET_33_OOP04;

public class Ticket( string movieName,decimal price)
{

private static int counter = 0;


    public int TicketID { get;}=++counter;

    public string MovieName { get; set; }=movieName;
    public decimal Price { get; set; }=price;

    public void SetPrice(decimal price) => Price = price;
    public void SetPrice(decimal price,decimal multiplier) => Price = price * multiplier;


    public virtual void PrintTicket()
    {
        Console.WriteLine($"Ticket ID: {TicketID}");
        Console.WriteLine($"Movie Name: {MovieName}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Price After Tax: {Price*1.14m:C}");
    }

    

}


