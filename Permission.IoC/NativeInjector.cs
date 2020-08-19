using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Permission.Application.Interfaces;
using Permission.Application.Services;
using Permission.Database.Context;
using Permission.Database.Repository;
using Permission.Domain.Interfaces;

namespace Permission.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            services.AddScoped<IPermissionAppService, PermissionAppService>();
            services.AddScoped<IPermissionTypeAppService, PermissionTypeAppService>();
            

            //Data
            services.AddScoped<IPermissionRespository, PermissionRespository>();
            services.AddScoped<IPermissionTypeRespository, PermissionTypeRespository>();
            services.AddDbContext<PermissionContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
