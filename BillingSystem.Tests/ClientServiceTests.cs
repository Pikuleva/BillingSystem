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
        private  IIPTVService iptvService;
        private  IInternetService internetService;
        private  ISatellieteService satelliteService;
        private  BillingSystemDbContext context;
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
        [Test]
        public async Task TestExistByCivilNumberAsync()
        {
            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 1,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber = "9102312234",
                StreetName = "",
                StreetNumber = "",
                PhoneNumber = "",
                Email = "",
                City = ""
            });
            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 2,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber = "9102312238",
                StreetName = "",
                StreetNumber = "",
                PhoneNumber = "",
                Email = "",
                City = ""
            });
            await repo.SaveChangesAsync();
            
            var dbClient = await repo.GetByIdAsync<Client>(1);
            var dbClient2 = await repo.GetByIdAsync<Client>(2);

            var exist = await clientService.ExistByCivilNumberAsync(dbClient.CivilNumber);
            var notExist = await clientService.ExistByCivilNumberAsync("9102312235");

            Assert.That(exist, Is.EqualTo(true));
            Assert.That(notExist, Is.EqualTo(false));
        }
        [Test]
        public async Task TestSearchClientAsync()
        {
            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 3,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                CivilNumber = "9102312234",
                StreetName = "",
                StreetNumber = "",
                PhoneNumber = "",
                Email = "",
                City = ""
            });
            await repo.SaveChangesAsync();

            var client = await clientService.SearchClientAsync("9102312234");

           

            Assert.That(client.CivilNumber, Is.EqualTo("9102312234"));
        }
        [Test]
        public async Task TestIsValidEmail()
        {
           var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

            await clientService.CreateAsync(new ClientFormModel()
            {
                Id=1,
                Email="valid@gmail.com"
            });
            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 2,
                Email = "notvalid.com"
            });
            await repo.SaveChangesAsync();
            var validClient = await repo.GetByIdAsync<Client>(1);
            var notValidClient = await repo.GetByIdAsync<Client>(2);

            bool valid = await clientService.IsValidEmail(validClient.Email);
            bool notValid =await clientService.IsValidEmail(notValidClient.Email);
            Assert.That(valid, Is.EqualTo(true));
            Assert.That(notValid, Is.EqualTo(false));
        }
        [Test]
        public async Task TestSearchClientDetailsAsync()
        {

            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);

            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 1,
                FirstName="Ivan",
                CivilNumber="8801012233",
                Email = ""
            });
            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 2,
                FirstName="Petkan",
                CivilNumber="7701023344",
                Email = ""
            });

            await repo.SaveChangesAsync();

            var client1=await clientService.SearchClientDetailsAsync(1);
            var client2=await clientService.SearchClientDetailsAsync(2);

            var client1ById = await repo.GetByIdAsync<Client>(1);
            var client2ById = await repo.GetByIdAsync<Client>(2);

            Assert.That(client1.FirstName, Is.EqualTo(client1ById.FirstName));
            Assert.That(client2.FirstName, Is.EqualTo(client2ById.FirstName));
        }

        [Test]
        public async Task TestAddIptvAsync()
        {

            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);
            iptvService = new IPTVService(repo);

          
            await iptvService.CreateAsync(new IPTVFormModel()
            {
                Id = 2,
                Name="TestIPTV"
            });

            await repo.SaveChangesAsync();
              await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 1,
                FirstName="Som"
            });
            await repo.SaveChangesAsync();

            await clientService.AddIptvAsync(1, 2);
            var client = await repo.GetByIdAsync<Client>(1);
            Assert.That(client.IPTVId,Is.EqualTo(2));
        }
        [Test]
        public async Task TestAddInternetAsync()
        {

            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);
            internetService = new InternetServiceC(repo);


            await internetService.CreateAsync(new InternetFormModel()
            {
                Id = 2,
                ClientId = 1
            });

            await repo.SaveChangesAsync();
            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 1,
                FirstName = "Som"
            });
            await repo.SaveChangesAsync();

            await clientService.AddInternetAsync(1, 2);
            var client = await repo.GetByIdAsync<Client>(1);
            Assert.That(client.InternetServiceId, Is.EqualTo(2));
        }
        [Test]
        public async Task TestAddSatelliteTvAsync()
        {

            var loggerMock = new Mock<ILogger<ClientService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            clientService = new ClientService(repo);
            satelliteService = new SatelliteService(repo);


            await satelliteService.CreateAsync(new SatelliteFormModel()
            {
                Id = 2,
                Name="SatTv"
            });

            await repo.SaveChangesAsync();
            await clientService.CreateAsync(new ClientFormModel()
            {
                Id = 1,
                FirstName = "Som"
            });
            await repo.SaveChangesAsync();

            await clientService.AddSatelliteTvAsync(1, 2);
            var client = await repo.GetByIdAsync<Client>(1);
            Assert.That(client.SatelliteTvId, Is.EqualTo(2));
        }
    }
}