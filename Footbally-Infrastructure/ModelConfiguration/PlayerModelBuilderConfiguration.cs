using Footbally_Domain.Entities.PlayerEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class PlayerModelBuilderConfiguration : BaseModelConfiguration<Player>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Player> builder)
    {
        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.ShirtNumber)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(m => m.Position)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(25);

        builder.Property(m => m.Age)
            .IsRequired()
            .HasDefaultValue(14);

        builder.Property(m => m.Goals)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(m => m.Assist)
            .IsRequired()
            .HasDefaultValue(0);


    }
}
