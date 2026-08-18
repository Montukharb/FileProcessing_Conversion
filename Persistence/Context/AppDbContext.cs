using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        private readonly IReadOnlyCollection<IAppDbContextModuleConfigurations> _Configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options) : this(options, []) //fallback configurations
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options, IEnumerable<IAppDbContextModuleConfigurations> configurations):base(options)
        {
            _Configuration = configurations.ToArray();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var configuration in _Configuration)
            {
                configuration.Configure(modelBuilder);
            }
        }
    }
}
