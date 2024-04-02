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
               Id= model.Id,
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

        public async Task EditAsync(int clientId, ClientFormModel model)
        {
            var client = await repository.GetByIdAsync<Client>(clientId);

            if (client != null)
            {
                client.StreetNumber = model.StreetNumber;
                client.City = model.City;
                client.Email=model.Email;
                client.StreetName= model.StreetName;
                client.PhoneNumber= model.PhoneNumber;    
            }
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

        public async Task<ClientDetail?> SearchClientAsync(string civilNumber)
        {
            
            var modelCivil= await repository.AllReadOnly<Client>()
                .Where(c=>c.CivilNumber==civilNumber)
                .Select(c=>new ClientDetail()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber= c.PhoneNumber,
                    Email = c.Email,
                    MiddleName= c.MiddleName,
                    Address = c.City + " " + c.StreetName + " " + c.StreetNumber
                })
                .FirstAsync();

           
                return modelCivil;
            
          
           
        }

        public async Task<ClientDetail> SearchClientDetailAsyn(int id)
        {
            return await repository.AllReadOnly<Client>()
                .Where(c => c.Id == id)
                .Select(c => new ClientDetail()
                {
                    Id= c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    MiddleName = c.MiddleName,
                    Address = c.City + " " + c.StreetName + " " + c.StreetNumber
                })
                .FirstAsync();   
        }
        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllReadOnly<Client>()
                .AnyAsync(h => h.Id == id);
        }

        public async Task<ClientFormModel> GetClientFormModelByIdAsync(int id)
        {
            var client = await repository.AllReadOnly<Client>()
                .Where(h => h.Id == id)
                .Select(h => new ClientFormModel()
                {
                    Id = h.Id,
                    StreetName = h.StreetName,
                    StreetNumber = h.StreetNumber,
                    City = h.City,
                    PhoneNumber= h.PhoneNumber,
                    Email = h.Email,
                    SatelliteFormModel = new SatelliteFormModel()
                    {
                        
                        CivilNumber = h.CivilNumber
                    },
                    InternetFormModel = new InternetFormModel()
                    {
                      
                        CivilNumber = h.CivilNumber

                    },
                    IPTVFormModel= new IPTVFormModel()
                    {
                       
                        CivilNumber = h.CivilNumber

                    }

                })
                .FirstAsync();
           
            return client;
        }

      
        public async Task<bool> GetSatTvServiceASyc(int id)
        {
            var model = await repository.AllReadOnly<Client>()
                .AnyAsync(c => c.SatelliteTvId == id);

            return model;
        }
    }
}
