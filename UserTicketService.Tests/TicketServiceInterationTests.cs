using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    public class TicketServiceInterationTests
    {
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            ticketServiceTest.DeleteTicket(newTicket);

            var allTicketAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketAfterDeletingNewTicket, newTicket);
        }
    }
}
