using iMessengerCoreAPI.Infrastructure.Managers.Interfaces;
using iMessengerCoreAPI.Infrastructure.Providers.Interfaces;

namespace iMessengerCoreAPI.Infrastructure.Managers;

/// <summary>
/// Manager for working with customer dialogues.
/// </summary>
public class DialogsClientsManager : IDialogsClientsManager
{
    private IDialogsClientsProvider _provider;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="provider">Interface for interacting with the database.</param>
    public DialogsClientsManager(IDialogsClientsProvider provider)
    {
        _provider = provider;
    }

    /// <summary>
    /// Find a dialog with the passed client IDs.
    /// </summary>
    /// <param name="clientIds">List of client IDs.</param>
    /// <returns>The identifier of the dialog in which all loyal clients are present, or an empty Guid if there is no such dialog.</returns>
    public Guid SearchDialogByClientIds(IEnumerable<Guid> clientIds)
    {
        if (clientIds == null ? true : !clientIds.Any()) return Guid.Empty;

        var groupWithClients = _provider.SearchDialogByClientIds(clientIds);
        return groupWithClients?.Key ?? Guid.Empty;
    }
}