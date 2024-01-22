using Microsoft.Extensions.DependencyInjection;
using Ojave.Core.Data;
using System.Reflection;

namespace Ojave.Core.DependencyInjection;

public static class RegisterDataAccess
{
    public static void AddParameterlessQueryObjects(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var typesForRegistration = assembly.GetTypes()
            .Where(c => c.IsClass && !c.IsAbstract && c.GetInterfaces()
                .Any(c => c.IsGenericType && c.GetGenericTypeDefinition() == typeof(IDbQuery<>)))
            .ToList();

        foreach (var type in typesForRegistration)
        {
            foreach (var @interface in type.GetInterfaces())
            {
                services.AddScoped(@interface, type);
            }
        }
    }

    public static void AddTQueryObjects(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var typesForRegistration = assembly.GetTypes()
            .Where(c => c.IsClass && !c.IsAbstract && c.GetInterfaces()
                .Any(c => c.IsGenericType && c.GetGenericTypeDefinition() == typeof(IDbQuery<,>)))
            .ToList();

        foreach (var type in typesForRegistration)
        {
            foreach (var @interface in type.GetInterfaces())
            {
                services.AddScoped(@interface, type);
            }
        }
    }

    public static void AddCommandObjects(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var typesForRegistration = assembly.GetTypes()
            .Where(c => c.IsClass && !c.IsAbstract && c.GetInterfaces()
                .Any(c => c.IsGenericType && c.GetGenericTypeDefinition() == typeof(IDbCommand<,>)))
            .ToList();

        foreach (var type in typesForRegistration)
        {
            foreach (var @interface in type.GetInterfaces())
            {
                services.AddScoped(@interface, type);
            }
        }
    }
}
