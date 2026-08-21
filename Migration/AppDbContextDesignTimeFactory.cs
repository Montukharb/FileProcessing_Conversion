using FileProcessingPL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using Persistence.Context;

namespace Infrastructure.FileProcessingMigration
{
    public sealed class AppDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var defaultConnectionString = "Server=(localdb)\\mssqllocaldb;Database=FileProcessing;Trusted_Connection=True;MultipleActiveResultSets=true";
            var ConnectionString = GetConnectionStringFromArgs(args) ?? Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING") ?? defaultConnectionString;

            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(connectionString: ConnectionString, sqlServerOptionsAction: options =>
            {
                options.MigrationsAssembly(MigrationAssembly.AssemblyName);
            }).Options;

            return new AppDbContext(optionBuilder, [new FileProcessingModuleConfigurations()]);
        }

        public static string? GetConnectionStringFromArgs(string[] args)
        {

            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i] is "-connectionString" or "-c")
                {
                    return args[i + 1];
                }
            }
            return null;
        }
    }
}
