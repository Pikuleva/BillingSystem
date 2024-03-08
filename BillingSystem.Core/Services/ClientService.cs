using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository repository;
        public ClientService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(ClientFormModel model)
        {

            var modelId = await repository
                .AllReadOnly<Client>()
                .OrderBy(x => x.Id) 
                .Select(x=>new ClientFormModel()
                {
                    LastId = x.Id
                })
                .TakeLast(1)
                .ToListAsync();

            var lastId = modelId.First();
            int lastIdValue = lastId.LastId;

            await repository.AddAsync(new Client()
            {
                ContractNumber = lastIdValue+ 100000,
                CivilNumber = model.CivilNumber,
                PhoneNumber = model.PhoneNumber,
                City =model.City,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                StreetName = model.StreetName,
                StreetNumber = model.StreetNumber,
                Email = model.Email

            });
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistByCivilNumberAsync(int civilNumber)
        {
            return await repository.AllReadOnly<Client>()
                .AnyAsync(a => a.CivilNumber == civilNumber);
        }
    }
}
