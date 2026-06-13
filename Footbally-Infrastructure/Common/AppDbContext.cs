using Footbally_Domain.Entities.PlayerEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.StandingEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;
using Footbally_Domain.Entities.UserEntity.Entity;

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
    public DbSet<PlayerPerformance> PlayerPerformances => Set<PlayerPerformance>();
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
