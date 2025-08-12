class TicketSystem
{
    private Queue<string> ticketQueue = new Queue<string>();
    private Stack<string> ticketHistory = new Stack<string>();

    public void CreateTicket(string customerName)
    {
        ticketQueue.Enqueue(customerName);
        Console.WriteLine($"[NEW] Ticket created for: {customerName}");
    }

    public void ProcessNextTicket()
    {
        if (ticketQueue.Count == 0)
        {
            Console.WriteLine("No tickets to process.");
            return;
        }

        string ticket = ticketQueue.Dequeue();
        ticketHistory.Push(ticket);
        Console.WriteLine($"[PROCESS] Ticket processed for: {ticket}");
    }

    public void ViewLastProcessedTicket()
    {
        if (ticketHistory.Count == 0)
        {
            Console.WriteLine("No tickets processed yet.");
            return;
        }

        Console.WriteLine($"[LAST PROCESSED] {ticketHistory.Peek()}");
    }

    public void UndoLastProcessedTicket()
    {
        if (ticketHistory.Count == 0)
        {
            Console.WriteLine("No tickets to undo.");
            return;
        }

        string ticket = ticketHistory.Pop();
        ticketQueue.Enqueue(ticket);
        Console.WriteLine($"[UNDO] Ticket for {ticket} returned to queue.");
    }
}

class Program
{
    static void Main()
    {
        TicketSystem system = new TicketSystem();

        system.CreateTicket("Alice");
        system.CreateTicket("Bob");
        system.CreateTicket("Charlie");
        Console.WriteLine(DateTime.Now.ToString());

        system.ProcessNextTicket();
        system.ProcessNextTicket();

        system.ViewLastProcessedTicket();

        system.UndoLastProcessedTicket();

        system.ProcessNextTicket();
        system.ProcessNextTicket();
    }
}