using EcommerceDev.Core.Repositories;
using EcommerceDev.Infrastructure.Messaging;
using EcommerceDev.Infrastructure.Messaging.Consumers;
using EcommerceDev.Infrastructure.Persistence;
using EcommerceDev.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceDev.Infrastructure;

public static class InfrastractureModule
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddInfrastructure(IConfiguration configuration)
        {
            services.AddData()
                .AddRepositories()
                .AddMessaging(configuration);
            
            return services;
        }

        private IServiceCollection AddData()
        {
            services
                .AddDbContext<EcommerceDbContext>(options => options.UseInMemoryDatabase("EcommerceDb"));
            
            return services;
        }
        
        private IServiceCollection AddRepositories()
        {
            services
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            
            return services;
        }
        
        private IServiceCollection AddMessaging(IConfiguration configuration)
        {
            var rabbitMqSettings = new RabbitMqSettings();
            
            configuration.GetSection("RabbitMQ").Bind(rabbitMqSettings);
            
            services.AddSingleton(rabbitMqSettings);
            
            services.AddSingleton<IEventPublisher, RabbitMqEventPublisher>();

            services.AddHostedService<OrderCreatedEventConsumer>();
            
            return services;
        }
    }
}