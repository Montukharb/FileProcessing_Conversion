using Microsoft.Extensions.DependencyInjection;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Context
{
    public static class AppDbContextSeeder
    {
        public static async Task SeedAppDbContextAsync(this IServiceProvider service)
        {
            using var scope = service.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var Seeders = scope.ServiceProvider.GetServices<IAppDbContextSeeder>();

            foreach (var seeder in Seeders)
            {
                await seeder.SeedAsync(dbContext);
            }
        }
    }
}
