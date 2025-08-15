using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Domain.Interfaces;
using OnlineStore.Infrastructure.Persistence;
using OnlineStore.Infrastructure.Persistence.Repositories;

namespace OnlineStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OnlineStoreDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // همین روند برای CustomerRepository و OrderRepository تکرار میشه
            return services;
        }
    }
}
