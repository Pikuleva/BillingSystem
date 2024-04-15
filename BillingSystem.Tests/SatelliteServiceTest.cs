using BillingSystem.Core.Contracts;
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
    public class SatelliteServiceTest
    {

        private IRepository repository;
        private ISatellieteService satelliteService;
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
        public async Task GetSatelliteFormModelAsync()
        {
            var loggerMock = new Mock<ILogger<SatelliteService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            satelliteService = new SatelliteService(repo);

            await satelliteService.CreateAsync(new SatelliteFormModel()
            {
                Id = 2,
                SerialNumber = 3222222,
                Name="TestGetSat"
            });
            await repo.SaveChangesAsync();

            var satTv = await satelliteService.GetSatelliteFormModelAsync(2);

            Assert.That(satTv.Name, Is.EqualTo("TestGetSat"));
        }
        [Test]
        public async Task ExistAsync()
        {
            var loggerMock = new Mock<ILogger<SatelliteService>>();
            logger = loggerMock.Object;
            var repo = new Repository(context);
            satelliteService = new SatelliteService(repo);

            await satelliteService.CreateAsync(new SatelliteFormModel()
            {
                Id = 2,
                SerialNumber = 3222233
            
            });
            await repo.SaveChangesAsync();

            var satTv = await satelliteService.ExistAsync(2);

            Assert.That(satTv, Is.EqualTo(true));
        }  
      
    }
}
