using Microsoft.EntityFrameworkCore;
using Footbally_Domain.Entities.PlayerEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.LeagueEntity.Entity;
using Footbally_Domain.Entities.StandingEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;
using System.Reflection;

namespace Footbally_Infrastructure.FootballyDbContext;

public class AppDbContext:DbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Match> Matchs { get; set; }
    public DbSet<League> Leagues { get; set; }
    public DbSet<Standing> Standings { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FootballyDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30")
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }



}
