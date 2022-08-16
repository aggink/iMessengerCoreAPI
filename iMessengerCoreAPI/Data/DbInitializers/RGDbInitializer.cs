using iMessengerCoreAPI.Data.DbContexts;
using iMessengerCoreAPI.Models;

namespace iMessengerCoreAPI.Data.DbInitializers;

/// <summary>
/// The class that provides methods for initializing the database with initial values.
/// </summary>
public static class RGDbInitializer
{
    /// <summary>
    /// Initializing the database with initial values.
    /// </summary>
    /// <param name="serviceProvider">Interface for retrieving a service object.</param>
    /// <returns>Task</returns>
    /// <exception cref="AggregateException">Error receiving services.</exception>
    public static async Task SeedAsync(IServiceProvider serviceProvider)
    {
        var scope = serviceProvider.CreateScope();
        await using var rgDbContext = scope.ServiceProvider.GetService<RGDbContext>();
        if (rgDbContext is null) throw new AggregateException(nameof(rgDbContext));

        await rgDbContext.DialogsClients.AddRangeAsync(RGDialogsClients.Init());
        await rgDbContext.SaveChangesAsync();
    }
}