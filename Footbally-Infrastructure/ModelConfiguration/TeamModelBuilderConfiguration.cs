using Footbally_Domain.Entities.StandingEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class TeamModelBuilderConfiguration : BaseModelConfiguration<Team>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Team> builder)
    {
        builder.HasMany(x => x.HomeMatches)
            .WithOne(x => x.HomeTeam)
            .HasForeignKey(x => x.HomeTeamId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.AwayMatches)
            .WithOne(x => x.AwayTeam)
            .HasForeignKey(x => x.AwayTeamId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.Players)
            .WithOne(x => x.Team)
            .HasForeignKey(x => x.TeamId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Standing)
            .WithOne()
            .HasForeignKey<Standing>(x => x.TeamId)
            .OnDelete(DeleteBehavior.NoAction);


        builder.Property(x => x.CoachName)
            .HasMaxLength(80);

        builder.Property(x => x.Country)
            .HasMaxLength(50);

        builder.HasData(
    new { Id = 1, Country = "Argentina", CoachName = "Lionel Scaloni", GroupNumber = 10 },
    new { Id = 2, Country = "Brazil", CoachName = "Carlo Ancelotti", GroupNumber = 3 },
    new { Id = 3, Country = "England", CoachName = "Thomas Tuchel", GroupNumber = 12 },
    new { Id = 4, Country = "France", CoachName = "Didier Deschamps", GroupNumber = 9 },
    new { Id = 5, Country = "Germany", CoachName = "Julian Nagelsmann", GroupNumber = 5 },
    new { Id = 6, Country = "Spain", CoachName = "Luis de la Fuente", GroupNumber = 8 },
    new { Id = 7, Country = "Portugal", CoachName = "Roberto Martinez", GroupNumber = 11 },
    new { Id = 8, Country = "Belgium", CoachName = "Rudi Garcia", GroupNumber = 7 },
    new { Id = 9, Country = "Netherlands", CoachName = "Ronald Koeman", GroupNumber = 6 },
    new { Id = 10, Country = "Croatia", CoachName = "Zlatko Dalic", GroupNumber = 12 },
    new { Id = 11, Country = "Switzerland", CoachName = "Murat Yakin", GroupNumber = 2 },
    new { Id = 12, Country = "Austria", CoachName = "Ralf Rangnick", GroupNumber = 10 },
    new { Id = 13, Country = "Sweden", CoachName = "Graham Potter", GroupNumber = 6 },
    new { Id = 14, Country = "Norway", CoachName = "Stale Solbakken", GroupNumber = 9 },
    new { Id = 15, Country = "Scotland", CoachName = "Steve Clarke", GroupNumber = 3 },
    new { Id = 16, Country = "Bosnia and Herzegovina", CoachName = "Sergej Barbarez", GroupNumber = 2 },
    new { Id = 17, Country = "Czechia", CoachName = "Miroslav Koubek", GroupNumber = 1 },
    new { Id = 18, Country = "Turkey", CoachName = "Vincenzo Montella", GroupNumber = 4 },

    new { Id = 19, Country = "Mexico", CoachName = "Javier Aguirre", GroupNumber = 1 },
    new { Id = 20, Country = "Canada", CoachName = "Jesse Marsch", GroupNumber = 2 },
    new { Id = 21, Country = "USA", CoachName = "Mauricio Pochettino", GroupNumber = 4 },
    new { Id = 22, Country = "Panama", CoachName = "Thomas Christiansen", GroupNumber = 12 },
    new { Id = 23, Country = "Curacao", CoachName = "Dick Advocaat", GroupNumber = 5 },
    new { Id = 24, Country = "Haiti", CoachName = "Sebastien Migne", GroupNumber = 3 },

    new { Id = 25, Country = "Japan", CoachName = "Hajime Moriyasu", GroupNumber = 6 },
    new { Id = 26, Country = "South Korea", CoachName = "Hong Myung-bo", GroupNumber = 1 },
    new { Id = 27, Country = "Iran", CoachName = "Amir Ghalenoei", GroupNumber = 7 },
    new { Id = 28, Country = "Australia", CoachName = "Tony Popovic", GroupNumber = 4 },
    new { Id = 29, Country = "Saudi Arabia", CoachName = "Georgios Donis", GroupNumber = 8 },
    new { Id = 30, Country = "Qatar", CoachName = "Julen Lopetegui", GroupNumber = 2 },
    new { Id = 31, Country = "Uzbekistan", CoachName = "Fabio Cannavaro", GroupNumber = 11 },
    new { Id = 32, Country = "Jordan", CoachName = "Jamal Sellami", GroupNumber = 10 },
    new { Id = 33, Country = "Iraq", CoachName = "Graham Arnold", GroupNumber = 9 },

    new { Id = 34, Country = "Morocco", CoachName = "Mohamed Ouahbi", GroupNumber = 3 },
    new { Id = 35, Country = "Senegal", CoachName = "Pape Thiaw", GroupNumber = 9 },
    new { Id = 36, Country = "Egypt", CoachName = "Hossam Hassan", GroupNumber = 7 },
    new { Id = 37, Country = "Algeria", CoachName = "Vladimir Petkovic", GroupNumber = 10 },
    new { Id = 38, Country = "South Africa", CoachName = "Hugo Broos", GroupNumber = 1 },
    new { Id = 39, Country = "Ghana", CoachName = "Carlos Queiroz", GroupNumber = 12 },
    new { Id = 40, Country = "Tunisia", CoachName = "Sabri Lamouchi", GroupNumber = 6 },
    new { Id = 41, Country = "Ivory Coast", CoachName = "Emerse Fae", GroupNumber = 5 },
    new { Id = 42, Country = "DR Congo", CoachName = "Sebastien Desabre", GroupNumber = 11 },
    new { Id = 43, Country = "Cape Verde", CoachName = "Bubista", GroupNumber = 8 },
    new { Id = 44, Country = "New Zealand", CoachName = "Darren Bazeley", GroupNumber = 7 },
    new { Id = 45, Country = "Uruguay", CoachName = "Marcelo Bielsa", GroupNumber = 8 },
    new { Id = 46, Country = "Colombia", CoachName = "Nestor Lorenzo", GroupNumber = 11 },
    new { Id = 47, Country = "Ecuador", CoachName = "Sebastian Beccacece", GroupNumber = 5 },
    new { Id = 48, Country = "Paraguay", CoachName = "Gustavo Alfaro", GroupNumber = 4 }
);

    }
}
