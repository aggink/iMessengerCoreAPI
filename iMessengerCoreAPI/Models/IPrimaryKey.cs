namespace iMessengerCoreAPI.Models;

/// <summary>
/// The interface that provides a contract for the presence of a primary key.
/// </summary>
public interface IPrimaryKey
{
    /// <summary>
    /// Primary key
    /// </summary>
    Guid IDUnique { get; set; }
}