// See https://aka.ms/new-console-template for more information

//Entry point that handles the users input and then directs the file
using NLog;

while (true)
{
    Console.WriteLine("1) Display tickets");
    Console.WriteLine("2) Enter ticket");
    Console.WriteLine("3) Exit");
    string resp = Console.ReadLine();
    logger.Info("User response: {resp}", resp);

    if (resp == "1")
    {
        Ticket.DisplayTickets();
    }
    else if (resp == "2")
    {
        Console.WriteLine("Enter severity");
        string severity = Console.ReadLine();
        Console.WriteLine("Enter software");
        string software = Console.ReadLine();
        Console.WriteLine("Enter reason");
        string reason = Console.ReadLine();
        Console.WriteLine("Enter the estimate");
        string estimate = Console.ReadLine();
        Console.WriteLine("Enter the cost");
        string cost = Console.ReadLine(); Console.WriteLine("Enter project name");
        string projectName = Console.ReadLine();
        Console.WriteLine("Enter due date");
        string dueDate = Console.ReadLine();

        TicketManager.EnterTicket(severity, software, reason, estimate, projectName, dueDate);
    }
    else if (resp == "3")
    {
        break;
    }
}

internal class TicketManager
{
    internal static void EnterTicket(string severity, string software, string reason, string estimate, string projectName, string dueDate)
    {
        throw new NotImplementedException();
    }
}