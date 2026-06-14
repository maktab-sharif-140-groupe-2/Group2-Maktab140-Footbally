using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;

namespace Footbally_Domain.Entities.StandingEntity.Service;

public interface IStandingService
{
    Task<bool> UpdateForWin(int teamId);

    Task<bool> UpdateForLose(int teamId);

    Task<bool> UpdateForDraw(int teamId);

}
