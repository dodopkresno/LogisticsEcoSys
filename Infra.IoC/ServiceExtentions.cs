using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core.Bus;
using Inventory.Data.Context;
using Inventory.Data.Data;
using Inventory.Data.Interface;
using LoggerService;
using MessageBroker.Infra.Bus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.IoC
{
    public static class ServiceExtentions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Logger Services
            services.AddScoped<ILoggerManager, LoggerManager>();

            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            services.AddDbContext<InventoryContext>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("InventoryDBConnection"), b => b.MigrationsAssembly("Inventory.API")));

            //Repository
            //Inventory Repository
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddTransient<InventoryContext>();
        }
    }
}
