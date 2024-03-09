using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

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
           string midleNameSet;
               
            if (model.MiddleName == null || model.MiddleName==string.Empty)
            {
                midleNameSet = string.Empty;
            }
            else
            {
                midleNameSet= model.MiddleName;
            }

            await repository.AddAsync(new Client()
            {
               
                CivilNumber = model.CivilNumber,
                PhoneNumber = model.PhoneNumber,
                City =model.City,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = midleNameSet,
                StreetName = model.StreetName,
                StreetNumber = model.StreetNumber,
                Email = model.Email

            });
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistByCivilNumberAsync(string civilNumber)
        {
            return await repository.AllReadOnly<Client>()
                .AnyAsync(a => a.CivilNumber == civilNumber);
        }
        public  bool IsValidEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
      
    }
}
