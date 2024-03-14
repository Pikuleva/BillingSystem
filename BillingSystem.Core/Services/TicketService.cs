using BillingSystem.Core.Contracts;
using BillingSystem.Infrastructure.Common;

namespace BillingSystem.Core.Services
{
    public class TicketService :ITicketService
    {
        private readonly IRepository repository;
        public TicketService(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
