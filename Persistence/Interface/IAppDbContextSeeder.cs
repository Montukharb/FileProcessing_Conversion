using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Interface;

    public interface IAppDbContextSeeder
    {
        public Task SeedAsync(AppDbContext dbContext, CancellationToken cancellationToken = default);
    }

