using iMessengerCoreAPI.Infrastructure.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iMessengerCoreAPI.Controllers;

/// <summary>
/// Controller for working with client dialogs.
/// </summary>
[ApiController]
[Route("[controller]/[action]")]
public class DialogsClientsController : Controller
{
    private readonly IDialogsClientsManager _manager;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="manager">The interface for interacting with a request handler from clients.</param>
    public DialogsClientsController(IDialogsClientsManager manager)
    {
        _manager = manager;
    }

    /// <summary>
    /// Find the dialog with the newly received client IDs.
    /// </summary>
    /// <param name="clientIds">List of client IDs.</param>
    /// <returns>Dialog identifier, if all loyal clients are present in this dialog, otherwise an empty Guid.</returns>
    /// <response code="200">If no such dialog is found, then an empty GUID is returned, otherwise the dialog ID is returned.</response>
    [HttpGet]
    public IActionResult SearchDialogByClientIds([FromQuery] IEnumerable<Guid> clientIds)
    {
        return Ok(_manager.SearchDialogByClientIds(clientIds));
    }
}