using Microsoft.Extensions.DependencyInjection;
using Repository.Contract;
using Repository.Imp;
using Services.Contract;
using Services.Imp;
namespace API.Config
{
    public static class CommonServices
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductServices, ProductServices>();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IProductsRepository, ProductRepository>();
        }
    }
}