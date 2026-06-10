using Footbally_Domain.Entities.TeamEntity.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class TeamModelBuilderConfiguration : BaseModelConfiguration<Team>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Team> builder)
    {
        builder.HasMany(x => x.HomeMatches)
            .WithOne(x => x.HomeTeam)
            .HasForeignKey(x => x.HomeTeamId);

        builder.HasMany(x => x.AwayMatches)
            .WithOne(x => x.AwayTeam)
            .HasForeignKey(x => x.AwayTeamId);

        builder.HasMany(x => x.Players)
            .WithOne(x => x.Team)
            .HasForeignKey(x => x.TeamId);

        builder.Property(x => x.CoachName)
            .HasMaxLength(80);

        builder.Property(x => x.Country)
            .HasMaxLength(50);

    }
}
