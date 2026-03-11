namespace G_NET_33_OOP04;

public class VIPTicket(string movieName,decimal price,bool loungeAccess,decimal serviceFee):Ticket(movieName,price)
{
public bool LoungeAccess { get; set; } = loungeAccess;
    public decimal ServiceFee { get; set; } = serviceFee;


public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"Lounge Access: {(LoungeAccess ? "Yes" : "No")}");
        Console.WriteLine($"Service Fee: {ServiceFee:C}");
    }
}
