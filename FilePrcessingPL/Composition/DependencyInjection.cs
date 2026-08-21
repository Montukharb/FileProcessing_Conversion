using FileProcessingPL.Context;
using FileProcessingPL.SeedExtension;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.Composition
{
    public static class DependencyInjection
    {
        public static IServiceCollection FileProcessingServices(this IServiceCollection services)
        {
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IAppDbContextModuleConfigurations, FileProcessingModuleConfigurations>());
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IAppDbContextSeeder, RoleSeeding>());

            return services;
        }
    }
}
