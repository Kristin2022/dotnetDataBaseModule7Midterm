using System.Collections.Generic;

public class TicketFile
{
    public string filePath { get; set; }
    public List<Ticket> Tickets { get; set; }

    public TicketFile(string filePath)
    {
        this.filePath = filePath;
        this.Tickets = new List<Ticket>();
    }
}
