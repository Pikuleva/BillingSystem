using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

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
        public async Task<bool> IsValidEmail(string email)
        {
            string regex = RegexValidationEmail;

            Match match = Regex.Match(email, regex, RegexOptions.IgnoreCase);

            if (email != string.Empty && match.Success)
            {
                return true;
            }
            return false;
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
                    CivilNumber=c.CivilNumber,
                    MiddleName= c.MiddleName,
                    Address = c.City + " " + c.StreetName + " " + c.StreetNumber
                })
                .FirstAsync();

           
                return modelCivil;          
        }

        public async Task<ClientDetail> SearchClientDetailsAsync(int id)
        {
            var interentId = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == id)
                .Select(c => c.InternetServiceId)
                .FirstAsync();
            var satteliteTvId = await repository.AllReadOnly<Client>()
               .Where(c => c.Id == id)
               .Select(c => c.SatelliteTvId)
               .FirstAsync();
            var iptvId = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == id)
                .Select(c => c.IPTVId)
                .FirstAsync();

            var model = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == id)
                .Select(c => new ClientDetail()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    MiddleName = c.MiddleName,
                    Address = c.City + " " + c.StreetName + " " + c.StreetNumber,
                   IPTVId=0,
                   InternetServiceId=0,
                   SatelliteTvId=0
                })
                .FirstAsync();
            if (iptvId != null)
            {
                model.IPTVId = (int)iptvId;
            }
            if (interentId != null)
            {
                model.InternetServiceId = (int)interentId;
            }
            if (satteliteTvId != null)
            {
                model.SatelliteTvId = (int)satteliteTvId;
            }
            return model;
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
                   

                })
                .FirstAsync();
           
            return client;
        }

        public async Task AddIptvAsync(int clientId, int iptvId)
        {
            var client = await repository.GetByIdAsync<Client>(clientId);
            var model = await repository.GetByIdAsync<IPTV>(iptvId);

            if (client != null && model != null)
            {
                client.IPTV = model;
                await repository.SaveChangesAsync();
            }
        }
        public async Task AddSatelliteTvAsync(int clientId, int satId)
        {
            var client = await repository.GetByIdAsync<Client>(clientId);
            var model = await repository.GetByIdAsync<SatelliteTV>(satId);

            if (client != null && model != null)
            {
                client.SatelliteTV = model;
                await repository.SaveChangesAsync();
            }
        }
        public async Task AddInternetAsync(int clientId, int internetId)
        {
            var client = await repository.GetByIdAsync<Client>(clientId);
            var model = await repository.GetByIdAsync<InternetService>(internetId);
            model.ClientId=clientId;
            if (client != null && model != null)
            {
                client.InternetService = model;
                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> IsValidCivilNumber(string civilNumber)
        {
            string regex = RegexCivilNumber;

            Match match = Regex.Match(civilNumber, regex, RegexOptions.IgnoreCase);

            if (civilNumber != string.Empty && match.Success)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> PhoneExist(string phoneNumber)
        {
            return await repository.AllReadOnly<Client>()
               .AnyAsync(h => h.PhoneNumber == phoneNumber);
        }
    }
}
