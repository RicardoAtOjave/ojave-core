using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Ojave.Core.DependencyInjection;
public static class AddRegistration
{
    public static IServiceCollection AddOjaveCore(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddParameterlessQueryObjects();
        services.AddTQueryObjects();
        services.AddCommandObjects();
        return services;
    }
}
