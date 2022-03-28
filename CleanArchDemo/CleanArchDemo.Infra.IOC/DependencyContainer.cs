using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            
            //Infrastructure Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}