using BillingSystem.Core.Contracts;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using BillingSystem.Infrastructure.DataModels.Enumeration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BillingSystem.Core.Services
{
    public class InternetServiceC : IInternetService
    {
        private readonly IRepository repository;
        public InternetServiceC(IRepository repository)
        {
            this.repository = repository;
        }

        //public async Task<InternetFormModel> AddNameToInternetProduct(string name)
        //{
        //    string searchName = string.Empty;
        //    if (name == "Интернет 25 Mbps - 10.99лв")
        //    {
        //        searchName = "InternetProduct25Mbps";
        //    } 
        //    if (name == "Интернет 50 Mbps - 12.99лв")
        //    {
        //        searchName = "InternetProduct50Mbps";
        //    } 
        //    if (name == "Интернет 75 Mbps - 14.99лв")
        //    {
        //        searchName = "InternetProduct75Mbps";
        //    }
        //    if (name == "Интернет 100 Mbps - 16.99лв")
        //    {
        //        searchName = "InternetProduct100Mbps";
        //    }

        //    return await repository.AllReadOnly<Product>()
        //        .Where(p=>p.Name == name.ToString())
        //        .Select(p=> new InternetFormModel()
        //        {
        //            InternetProducts=searchName,
        //            Price=p.Price               
        //        })
        //        .FirstAsync();
        //}

        public async Task CreateAsync(InternetFormModel model)
        {
            var products =await repository.AllReadOnly<Product>()
                .Select(p=>p.Name)
                .ToListAsync();
           
           await repository.AddAsync(new InternetService()
            {
                
                RouterMACAdress = model.RouterMACAdress,
                ActiveUntilDate=model.UntilDate
            });

           await repository.SaveChangesAsync();
        }

        public Task<InternetFormModel> CreateInternetFormModel(string macAddress, InternetProductsWithPrice name, DateTime untilDate)
        {
            throw new NotImplementedException();
        }
        public async Task<InternetFormModel> AddPropToModel(string name, decimal price, string mac, DateTime date)
        {

            var model = new InternetFormModel()
            {
              
                UntilDate = date,
                RouterMACAdress = mac
            };

            return model;
        }

        public async Task<ClientFormModel> GetClientByIdAsync(int clientId)
        {
            return await repository.AllReadOnly<Client>()
                .Where(c=>c.Id==clientId)
                .Select(c=>new ClientFormModel()
                {                   
                    PhoneNumber = c.PhoneNumber,
                    CivilNumber = c.CivilNumber,
                    FirstName = c.FirstName,
                    MiddleName = c.MiddleName,
                    StreetName  = c.StreetName,
                    LastName = c.LastName,
                    City = c.City,
                    Email = c.Email,
                    StreetNumber = c.StreetNumber,
                    InternetFormModel= new InternetFormModel()
                })
                .FirstAsync();
        }
    }
}
