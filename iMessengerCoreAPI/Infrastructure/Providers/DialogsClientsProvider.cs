using iMessengerCoreAPI.Data.DbContexts;
using iMessengerCoreAPI.Infrastructure.Providers.Interfaces;
using iMessengerCoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace iMessengerCoreAPI.Infrastructure.Providers;

/// <summary>
/// Provider for working with client dialogs processing requests to the database.
/// </summary>
public class DialogsClientsProvider : IDialogsClientsProvider
{
    private readonly RGDbContext _dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">The object that provides a session with the database and interaction with it.</param>
    public DialogsClientsProvider(RGDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Find a dialog with the passed client IDs.
    /// </summary>
    /// <param name="clientIds">List of client IDs.</param>
    /// <returns>The collection of clients with a common dialog ID, or null if no such dialog is found.</returns>
    public IGrouping<Guid, RGDialogsClients>? SearchDialogByClientIds(IEnumerable<Guid> clientIds)
    {
        return _dbContext.DialogsClients
            .AsEnumerable()
            .GroupBy(x => x.IDRGDialog)
            .Where(group => group.All(dialogClient => clientIds.Any(id => id == dialogClient.IDClient)))
            .FirstOrDefault();
    }
}