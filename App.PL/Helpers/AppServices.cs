using App.BLL.Interfaces;
using App.BLL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace App.PL.Helpers
{
    public static class AppServices
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddAutoMapper(M => M.AddProfile(new MappingProfile()));
            services.AddAutoMapper(M => M.AddProfile(new DepartmetProfile()));
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
