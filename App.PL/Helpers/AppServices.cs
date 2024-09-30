using App.BLL.Interfaces;
using App.BLL.Repositories;
using App.DAL.Data;
using App.DAL.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
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
			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();
			services.Configure<IdentityOptions>(options =>
			 {
				 options.Password.RequireNonAlphanumeric = false;
			 });
			services.AddAuthentication();
		//.AddCookie("Auth",options =>
		//{
			
		//	options.LoginPath = "/Account/SignIn"; // Specify the login path
		//	options.AccessDeniedPath = "/Account/SignIn";// Optional: Handle access denied case
		//});
			return services;
		}
	}
}
