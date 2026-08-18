using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Composition
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDbContextDependencyInjection(this IServiceCollection service, Action<IServiceProvider, DbContextOptionsBuilder> configureOptions)
        {
            service.AddDbContext<AppDbContext>((serviceProvider, options) => //serviceprovider and option provide ef core
            {
                configureOptions(serviceProvider, options); //call back method
            });

            return service;
        }
    }
}
