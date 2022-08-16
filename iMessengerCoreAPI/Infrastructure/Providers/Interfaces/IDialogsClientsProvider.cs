using iMessengerCoreAPI.Models;

namespace iMessengerCoreAPI.Infrastructure.Providers.Interfaces;

/// <summary>
/// Interface providing a contract for DialogsClientsProvider.
/// </summary>
public interface IDialogsClientsProvider
{
    /// <summary>
    /// Find a dialog with the passed client IDs.
    /// </summary>
    /// <param name="clientIds">List of client IDs.</param>
    /// <returns>The collection of clients with a common dialog ID, or null if no such dialog is found.</returns>
    IGrouping<Guid, RGDialogsClients>? SearchDialogByClientIds(IEnumerable<Guid> clientIds);
}