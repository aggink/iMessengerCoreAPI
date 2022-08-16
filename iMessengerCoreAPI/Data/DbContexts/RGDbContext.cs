using iMessengerCoreAPI.Data.DbModelConfigs;
using iMessengerCoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace iMessengerCoreAPI.Data.DbContexts;

/// <summary>
/// The class that provides templates for working with a database.
/// </summary>
public class RGDbContext : DbContext
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="options">Parameters used by the DbContext parameter.</param>
    public RGDbContext(DbContextOptions<RGDbContext> options) 
        : base(options) { }

    /// <summary>
    /// DialogsClients
    /// </summary>
    public DbSet<RGDialogsClients> DialogsClients { get; set; } = null!;

    /// <summary>
    /// Model setup.
    /// </summary>
    /// <param name="modelBuilder">Provides an API for customizing the shape of entities, relationships between them, and mapping them to a database.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly(),
                x => x.GetInterfaces()
                    .Any(i => i == typeof(IConfig)));
        base.OnModelCreating(modelBuilder);
    }
}