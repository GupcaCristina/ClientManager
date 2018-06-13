using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;


namespace ClientManager.DAL.EF
{
    class TempLearningPortalContextFactoryIDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ClientManagerContext>
    {
        public ClientManagerContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ClientManagerContext>();
            DbContextOptions<ClientManagerContext> options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            ClientManagerContext clientManagerContext = Activator.CreateInstance(typeof(ClientManagerContext), new object[] { options }) as ClientManagerContext; 
            return clientManagerContext;
        }
    }
}
