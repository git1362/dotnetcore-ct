using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using MongoDB.Adapter.Repositories;
using MongoDB.Adapter.Settings;

namespace MongoDB.Adapter
{
    public static class MongoServiceRegistration
    {
        public static IServiceCollection RegisterMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));

            services.Configure<MongoDbSettings>((mongoDbSection) => configuration.GetSection("MongoDbSettings"));

            services.AddSingleton<IMongoDbSettings>(serviceProvider =>
                serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

            services.AddHealthChecks()
                   .AddMongoDb(configuration["DatabaseSettings:ConnectionString"], "MongoDb Health", HealthStatus.Degraded);

            return services;
        }
    }
}