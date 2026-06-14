using Footbally_Common.Dto.Request.PlayerPerformance;

namespace Footbally_Domain.Entities.PlayerPerformanceEntity.Service;

public interface IPlayerPerformance
{
    Task<bool> Create(PlayerPerformanceRequestDto request);

}
