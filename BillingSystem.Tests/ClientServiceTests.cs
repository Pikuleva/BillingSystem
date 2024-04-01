using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Data;
using BillingSystem.Infrastructure.Common;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Logging;
using BillingSystem.Core.ViewModels;
using BillingSystem.Infrastructure.DataModels;

namespace BillingSystem.Tests
{
    [TestFixture]
    public class ClientServiceTests
    {
        private  IRepository repository;
        private  IClientService clientService;
        private  BillingSystemDbContext context;
        private ILogger logger;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<BillingSystemDbContext>()
                   .UseInMemoryDatabase("HouseDB")
                   .Options;

            context = new BillingSystemDbContext(contextOptions);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        [Test]
        public async Task TestClientEdit()
        {
            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

            await repo.AddAsync(new Client()
            {
                Id = 1,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber="",
                StreetName="",
                StreetNumber="",
                PhoneNumber = "",
                Email = "",
                City = ""
            });

            await repo.SaveChangesAsync();

            await clientService.EditAsync(1, new ClientFormModel()
            {
                Id = 1,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber = "",
                StreetName = "",
                StreetNumber = "",
                PhoneNumber="",
                Email="",
                City = "Plovdiv"
            });

            var dbClient = await repo.GetByIdAsync<Client>(1);

            Assert.That(dbClient.City, Is.EqualTo("Plovdiv"));
        }
        [Test]
        public async Task TestCreateAsync()
        {
            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

         
            

            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 2,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber = "",
                StreetName = "",
                StreetNumber = "",
                PhoneNumber = "",
                Email = "",
                City = "Created"
            });
            await repo.SaveChangesAsync();

            var dbClient = await repo.GetByIdAsync<Client>(2);

            Assert.That(dbClient.City, Is.EqualTo("Created"));

        }
    }
}