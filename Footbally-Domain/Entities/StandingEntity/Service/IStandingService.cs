using Footbally_Common.Enums.Standing;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;

namespace Footbally_Domain.Entities.StandingEntity.Service;

public interface IStandingService
{
    /// <summary>
    /// بروزرسانی اطلاعات جدولی یک تیم مشخص
    /// </summary>
    /// <param name="teamId"></param>
    /// <param name="gameResult"></param>
    /// <param name="goalsFor"></param>
    /// <param name="goalsAgainst"></param>
    /// <returns></returns>
    Task UpdateStandingInfo(int teamId,GameResult gameResult, int goalsFor = 0, int goalsAgainst=0);



}
