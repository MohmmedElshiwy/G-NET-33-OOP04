namespace G_NET_33_OOP04;

public class IMAXTicket(string movieName,decimal price,bool is3D):Ticket(movieName,price)
{
public bool Is3D { get; set; } = is3D;
public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($"3D Experience: {Is3D }");
    }

}
