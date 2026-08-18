using FileProcessingPL.Composition;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleComposition
{
    public static class DependencyInjection
    {
        public static IServiceCollection ModuleCompositionServices(this IServiceCollection services)
        {
            services.FileProcessingServices();
            return services;
        }
    }



    }

