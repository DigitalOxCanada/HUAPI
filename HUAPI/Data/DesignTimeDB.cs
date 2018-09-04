using HUAPIClassLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HUAPICore.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HUAPIDBContext>
    {
        public HUAPIDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
            var builder = new DbContextOptionsBuilder<HUAPIDBContext>();
            var connectionString = configuration.GetConnectionString("HUAPIDB");
            builder.UseSqlServer(connectionString);
            return new HUAPIDBContext(builder.Options);
        }
    }
}
