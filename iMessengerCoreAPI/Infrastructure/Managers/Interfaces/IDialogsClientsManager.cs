namespace iMessengerCoreAPI.Infrastructure.Managers.Interfaces;

/// <summary>
/// Interface providing a contract for DialogsClientsManager.
/// </summary>
public interface IDialogsClientsManager
{
    /// <summary>
    /// Find a dialog with the passed client IDs.
    /// </summary>
    /// <param name="clientIds">List of client IDs.</param>
    /// <returns>The identifier of the dialog in which all loyal clients are present, or an empty Guid if there is no such dialog.</returns>
    Guid SearchDialogByClientIds(IEnumerable<Guid> clientIds);
}