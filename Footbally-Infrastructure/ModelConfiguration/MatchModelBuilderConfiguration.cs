using Footbally_Domain.Entities.GameEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


using System.Text.RegularExpressions;

namespace Footbally_Infrastructure.ModelConfiguration;

public class MatchModelBuilderConfiguration : BaseModelConfiguration<Game>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Game> builder)
    {
        builder.Property(m => m.MatchDate)
            .IsRequired();
            
        builder.Property(m => m.Status)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(10);

        builder.Property(m => m.Status)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(15);

        builder.HasMany(x => x.PlayerPerformances)
            .WithOne(x => x.Match)
            .HasForeignKey(x => x.MatchId)
            .OnDelete(DeleteBehavior.NoAction);

    }
}
