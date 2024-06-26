﻿using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Core.ViewModels;
using BillingSystem.Data;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace BillingSystem.Tests
{
    public class InternetServiceTest
    {
        private IRepository repository;
        private IInternetService internetService;
        private IClientService clientService;
        private BillingSystemDbContext context;
        private ILogger logger;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<BillingSystemDbContext>()
                   .UseInMemoryDatabase("BillingSystemDB")
                   .Options;

            context = new BillingSystemDbContext(contextOptions);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        [Test]
        public async Task TestCreateAsync()
        {
            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            internetService = new InternetServiceC(repo);

            await internetService.CreateAsync(new InternetFormModel()
            {
                Id = 2,
                RouterMACAdress = "5F:7F:81:98:98:12"
            });
            await repo.SaveChangesAsync();

            var internet = await repo.GetByIdAsync<InternetService>(2);

            Assert.That(internet.RouterMACAdress, Is.EqualTo("5F:7F:81:98:98:12"));
        }
        [Test]
        public async Task ExistAsync()
        {
            var loggerMock = new Mock<ILogger<InternetServiceC>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            internetService = new InternetServiceC(repo);

            await internetService.CreateAsync(new InternetFormModel()
            {
                Id = 2,
                RouterMACAdress = "5F:7F:80:98:98:12"

            });
            await repo.SaveChangesAsync();

            var satTv = await internetService.ExistAsync(2);

            Assert.That(satTv, Is.EqualTo(true));
        }
        [Test]
        public async Task GetInternetFormModelByIdAsync()
        {
            var loggerMock = new Mock<ILogger<InternetServiceC>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            internetService = new InternetServiceC(repo);

            await internetService.CreateAsync(new InternetFormModel()
            {
                Id = 2,
                RouterMACAdress = "8A:9C:0E:7A:00:F1"
                
            });
            await repo.SaveChangesAsync();

            var net = await internetService.GetInternetFormModelByIdAsync(2);

            Assert.That(net.RouterMACAdress, Is.EqualTo("8A:9C:0E:7A:00:F1"));
        }
        [Test]
        public async Task IsValidMAC()
        {

            var loggerMock = new Mock<ILogger<InternetService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            internetService = new InternetServiceC(repo);


            var valid = await internetService.IsValidMacAddressAsync("8F:9D:80:2A:7B:6B");
            var NotValid = await internetService.IsValidMacAddressAsync("8F:9D:80:2A:7M:6B");

            Assert.That(valid, Is.EqualTo(true));
            Assert.That(NotValid, Is.EqualTo(false));
        }
    }
}
