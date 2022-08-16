using iMessengerCoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iMessengerCoreAPI.Data.DbModelConfigs;

/// <summary>
/// The class containing the configuration of the model and its properties.
/// </summary>
public class RGDialogsClientsModelConfig : IEntityTypeConfiguration<RGDialogsClients>, IConfig
{
    /// <summary>
    /// Model setup.
    /// </summary>
    /// <param name="builder">API for setting up the model.</param>
    public void Configure(EntityTypeBuilder<RGDialogsClients> builder)
    {
        builder.HasKey(x => x.IDUnique);

        builder.Property(x => x.IDUnique).IsRequired();
        builder.Property(x => x.IDClient).IsRequired();
        builder.Property(x => x.IDRGDialog).IsRequired();
        builder.Property(x => x.DateEvent);
    }
}