public abstract class Ticket
{
    // Properties common to all tickets
    public int Id { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string Submitter { get; set; }
    public string Assigned { get; set; }
    public string Watching { get; set; }

    // Constructor
    public Ticket(int id, string summary, string status, string priority, string submitter, string assigned, string watching)
    {
        Id = id;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        Assigned = assigned;
        Watching = watching;
    }

    // method to be overridden in classes
    public abstract string DisplayTickets();
}



