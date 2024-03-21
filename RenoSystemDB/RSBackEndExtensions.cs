using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RenoSystemDB.BLL;
using RenoSystemDB.DAL;


namespace RenoSystemDB
{
    public static class RSBackEndExtensions
    {       
        public static void RSBackendDependencies(this IServiceCollection services,
            Action<DbContextOptionsBuilder> options) 
        {
            services.AddDbContext<RenosContext>(options);

            services.AddTransient<JobServices>((ServiceProvider) =>
            {
                var context = ServiceProvider.GetService<RenosContext>();
                return new JobServices(context!);
            });

            services.AddTransient<SupplyServices>((serviceProvider) =>
            {
                var context = serviceProvider.GetService<RenosContext>();
                return new SupplyServices(context!);
            });

        }

    }
}
