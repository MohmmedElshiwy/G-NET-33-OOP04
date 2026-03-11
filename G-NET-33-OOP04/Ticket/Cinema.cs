namespace G_NET_33_OOP04;

public class Cinema
{

    private List<Ticket> tickets = new List<Ticket>();

    public void AddTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public void PrintAllTickets()
    {
        for(int i = 0; i < tickets.Count; i++)
        {
            Console.WriteLine($"Ticket {i + 1}:");
            tickets[i].PrintTicket();
            Console.WriteLine("-----------------------");
        }
    }


    public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n=== Processing Ticket ===");
            t.PrintTicket();
            Console.WriteLine("------------------------");
        }

        public void OpenCinema()
        {
            Console.WriteLine("Cinema is now OPEN!\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\nCinema is now CLOSED!");
        }
    }


