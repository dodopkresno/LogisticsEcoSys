using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core.Bus;
using Inventory.Application.Interface;
using Inventory.Application.Mapping;
using Inventory.Application.Services;
using Inventory.Data.Context;
using Inventory.Data.Data;
using Inventory.Data.Interface;
using Inventory.Domain.Interface;
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
                opts.UseNpgsql(configuration.GetConnectionString("InventoryDBConnection"), b => b.MigrationsAssembly("Inventory.Data")));

            //Repository
            //Inventory Repository
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddTransient<InventoryContext>();

            //ApplicationService
            services.AddScoped<IUomCategoryMapper, UomCategoryMapper>();
            services.AddScoped<IUomCategoryService, UomCategoryService>();
        }
    }
}
