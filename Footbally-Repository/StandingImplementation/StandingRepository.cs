using Footbally_Common.Enums.Standing;
using Footbally_Domain.Entities.StandingEntity.Data;
using Footbally_Domain.Entities.StandingEntity.Entity;
using Footbally_Infrastructure.Common;
using Footbally_Repository.Common;

namespace Footbally_Repository.StandingImplementation;

public class StandingRepository : GenericRepository<Standing>, IStandingRepository
{
    public StandingRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    /// <summary>
    /// بروز رسانی اطلاعات یک تیم مشخص در جدول
    /// </summary>
    /// <param name="standing"></param>
    /// <param name="gameResult"></param>
    /// <param name="goalsFor"></param>
    /// <param name="goalsAgainst"></param>
    /// <returns></returns>
    public async Task UpdateStandingStatus(Standing standing, GameResult gameResult, int goalsFor, int goalsAgainst)
    {
        if (gameResult == GameResult.Win)
        {
            standing.SetWin(goalsFor, goalsAgainst);
        }
       else if (gameResult == GameResult.Lose)
        {
            standing.SetLost(goalsFor, goalsAgainst);
        }
       else if (gameResult == GameResult.Win)
        {
            standing.SetDraw(goalsFor, goalsAgainst);
        }
       await DbContext.SaveChangesAsync();
    }
}
