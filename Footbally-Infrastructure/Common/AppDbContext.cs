using Footbally_Domain.Entities.PlayerEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.StandingEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Footbally_Infrastructure.Common;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {
        
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<Match> Matchs => Set<Match>();
    public DbSet<Standing> Standings => Set<Standing>();
    public DbSet<Team> Teams => Set<Team>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
