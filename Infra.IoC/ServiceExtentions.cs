using System;
using System.Collections.Generic;
using System.Text;
using LoggerService;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.IoC
{
    public static class ServiceExtentions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }
    }
}
