using Footbally_Domain.Entities.StandingEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class StandingModelBuilderConfiguration : BaseModelConfiguration<Standing>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Standing> builder)
    {


        builder.HasData(
     new { Id = 1, TeamId = 1, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 2, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 3, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 4, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 5, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 6, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 7, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 8, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 9, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 10, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 11, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 12, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 13, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 14, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 15, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 16, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 17, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 18, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 19, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 20, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 21, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 22, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 23, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 24, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 25, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 26, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 27, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 28, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 29, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 30, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 31, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 32, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 33, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 34, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 35, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 36, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 37, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 38, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 39, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 40, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 41, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 42, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 43, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 44, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 45, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 46, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 47, TeamId = 2, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 },
     new { Id = 48, TeamId = 48, Played = 0, Won = 0, Lost = 0, Draw = 0, GoalsFor = 0, GoalsAgainst = 0, Points = 0 });
  
    }
}
