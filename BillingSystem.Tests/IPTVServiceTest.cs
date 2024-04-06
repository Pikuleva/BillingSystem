using BillingSystem.Core.Contracts;
using BillingSystem.Core.Services;
using BillingSystem.Data;
using BillingSystem.Infrastructure.Common;
using BillingSystem.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Microsoft.Extensions.Logging;
using BillingSystem.Core.ViewModels;

namespace BillingSystem.Tests
{
    [TestFixture]
    public class IPTVServiceTest
    {
        private IRepository repository;
        private IIPTVService iptvService;
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
                iptvService = new IPTVService(repo);

                await iptvService.CreateAsync(new IPTVFormModel()
                {
                    Id = 2,
                   SerialNumber=3222222
                });
                await repo.SaveChangesAsync();

                var iptv = await repo.GetByIdAsync<IPTV>(2);

                Assert.That(iptv.SerialNumber, Is.EqualTo(3222222));
            }

    }
}

