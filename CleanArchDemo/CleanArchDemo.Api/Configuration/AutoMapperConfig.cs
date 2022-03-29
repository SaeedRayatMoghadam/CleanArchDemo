using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Api.Configuration
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(Application.AutoMapper.AutoMapperConfig));
            Application.AutoMapper.AutoMapperConfig.RegisterMapping();
        }
    }
}