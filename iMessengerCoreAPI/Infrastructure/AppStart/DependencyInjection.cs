using iMessengerCoreAPI.Data.DbContexts;
using iMessengerCoreAPI.Infrastructure.Managers;
using iMessengerCoreAPI.Infrastructure.Managers.Interfaces;
using iMessengerCoreAPI.Infrastructure.Providers;
using iMessengerCoreAPI.Infrastructure.Providers.Interfaces;
using iMessengerCoreAPI.Models;

namespace iMessengerCoreAPI.Infrastructure.AppStart;

/// <summary>
/// The class that provides methods for registering services.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Add service dependencies.
    /// </summary>
    /// <param name="services">The contract for a collection of service descriptors.</param>
    /// <returns>Contract for a collection of service descriptors.</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IDialogsClientsProvider, DialogsClientsProvider>();
        services.AddTransient<IDialogsClientsManager, DialogsClientsManager>();

        return services;
    }
}