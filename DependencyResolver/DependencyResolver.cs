using BusinessLayer.Implementation;
using BusinessLayer.Interface;
using DataAccessLayer.Repositories.Implementation;
using DataAccessLayer.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyResolver
{
    public static class DependencyResolver
    {
        public static IServiceCollection ResolverDependency(this IServiceCollection services)
        {
            return services.RegisterServices().RegisterRepository();
        }
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEmpServices, EmpServices>();
            return services;
        }
        public static IServiceCollection RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped<IEmpRepository, EmpRepository>();
            return services;
        }
    }
}
