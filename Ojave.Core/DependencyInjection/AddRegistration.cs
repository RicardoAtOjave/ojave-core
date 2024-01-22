using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Ojave.Core.DependencyInjection;
public static class AddRegistration
{
    public static IServiceCollection AddOjaveCore(this IServiceCollection services, Assembly assembly)
    {
        services.AddAutoMapper(assembly);
        services.AddParameterlessQueryObjects(assembly);
        services.AddTQueryObjects(assembly);
        services.AddCommandObjects(assembly);
        return services;
    }
}
