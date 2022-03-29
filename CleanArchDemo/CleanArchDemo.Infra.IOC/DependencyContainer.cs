using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using CleanArchDemo.Domain.CommandHandlers;
using CleanArchDemo.Domain.Commands;
using CleanArchDemo.Domain.Core.Bus;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infra.Bus;
using CleanArchDemo.Infra.Data.Context;
using CleanArchDemo.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            
            //Infrastructure Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();

        }
    }
}