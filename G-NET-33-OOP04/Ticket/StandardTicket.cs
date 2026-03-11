namespace G_NET_33_OOP04;

public class StandardTicket(string movieName, decimal price,string seatNumber): Ticket( movieName,  price)
{
   
       public string SeatNumber { get; set; } = seatNumber;


    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Seat Number: {SeatNumber}");
    }

}
