using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core.Bus;
using Inventory.Data.Data;
using Inventory.Data.Interface;
using LoggerService;
using MessageBroker.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.IoC
{
    public static class ServiceExtentions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Logger Services
            services.AddScoped<ILoggerManager, LoggerManager>();

            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Repository
            //Inventory Repository
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
