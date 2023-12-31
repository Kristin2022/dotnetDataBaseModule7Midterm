public class Task : Ticket
{
    // Additional properties for Task
    public string ProjectName { get; set; }
    public DateTime DueDate { get; set; }

    // Constructor
    public Task(int id, string summary, string status, string priority, string submitter, string assigned, string watching,
                string projectName, DateTime dueDate)
        : base(id, summary, status, priority, submitter, assigned, watching)
    {
        ProjectName = projectName;
        DueDate = dueDate;
    }

    // Override DisplayTickets method
    public override string DisplayTickets()
    {
        return $"Id: {Id}\nSummary: {Summary}\nStatus: {Status}\nPriority: {Priority}\nSubmitter: {Submitter}\nAssigned: {Assigned}\nWatching: {Watching}" +
               $"\nProjectName: {ProjectName}\nDueDate: {DueDate}";
    }
}
