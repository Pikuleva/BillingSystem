﻿using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using static BillingSystem.Infrastructure.DataModels.Constants.ValidationEntity.ClientContract;

namespace BillingSystem.Core.Services
{
    public class InternetServiceC : IInternetService
    {
        private readonly IRepository repository;
        public InternetServiceC(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(InternetFormModel model)
        {
            InternetService internet = new InternetService()
            {
                Name = model.Name.ToString(),
                ActiveUntilDate = model.ActiveUntilDate,
                ProductId = model.ProductModelId,
                RouterMACAdress = model.RouterMACAdress,
             

            };
          
            await repository.AddAsync(internet);
            await repository.SaveChangesAsync();

            return internet.Id;
        }

        public async Task<IEnumerable<ProductModel>> GetProductModelIdAsync()
        {
            return await repository.AllReadOnly<Product>()
                .Where(p => p.TypeId == 1)
                .Select(p => new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price

                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TypeOfServiceModel>> GetTypeModel()
        {
            return await repository.AllReadOnly<TypeOfService>()
              .Select(t => new TypeOfServiceModel()
              {
                  Id = t.Id,
                  Name = t.Name

              })
              .ToListAsync();
        }

        public async Task<InternetDetails> InternetServiceDetailsAsync(int clientId)
        {
            var service = await repository.AllReadOnly<Client>()
                .Where(c=>c.Id==clientId)
                .Select(c=>c.InternetServiceId)
                .FirstAsync();
           
            if (service == null)
            {
                return null;
            }

            InternetDetails clientInternet = await repository.AllReadOnly<Client>()
                .Where(c => c.Id == clientId)
                .Select(c => new InternetDetails()
                { 
                    Id=c.InternetService.Id,
                    Name = c.InternetService.Name,
                    RouterMAC = c.InternetService.RouterMACAdress,
                    ActiveUntilDate = c.InternetService.ActiveUntilDate,
                    Price = c.InternetService.Product.Price,
                    ClientId= clientId
                })
                .FirstAsync();
          

            return clientInternet;
        }

        public async Task<bool> IsExistMACAddress(string macAddress)
        {
            return await repository.AllReadOnly<InternetService>()
                .AnyAsync(m => m.RouterMACAdress == macAddress);
        }
        public async Task<bool> ExistAsync(int id)
        {
            return await repository.AllReadOnly<InternetService>()
                .AnyAsync(h => h.Id == id);
        }
        public async Task<InternetFormModel> GetInternetFormModelByIdAsync(int id)
        {
            var internet = await repository.AllReadOnly<InternetService>()
                .Where(h => h.Id == id)
                .Select(h => new InternetFormModel()
                {
                    Id = h.Id,
                    ActiveUntilDate = h.ActiveUntilDate,
                    RouterMACAdress = h.RouterMACAdress,
                    ProductModelId=h.ProductId,
                    ClientId=h.ClientId
                })
                .FirstAsync();

            return internet;
        }
        public async Task EditAsync(int internetId, InternetFormModel model)
        {
            var internet = await repository.GetByIdAsync<InternetService>(internetId);

            if (internet != null)
            {
                internet.ActiveUntilDate = model.ActiveUntilDate;
                internet.RouterMACAdress = model.RouterMACAdress;
                internet.ProductId = model.ProductModelId;
                model.ClientId = internet.ClientId;
            }
            await repository.SaveChangesAsync();
        }
        public async Task<bool> IsValidMacAddressAsync(string MACAddress)
        {
            string regex = RegexMACAddress;

            Match match = Regex.Match(MACAddress, regex, RegexOptions.IgnoreCase);

            if (MACAddress != string.Empty && match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
