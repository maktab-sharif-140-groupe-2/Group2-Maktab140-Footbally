using Footbally_Common.Dto.Request.PlayerPerformance;

namespace Footbally_Domain.Entities.PlayerPerformanceEntity.Service;

public interface IPlayerPerformanceService
{
    /// <summary>
    /// ثبت گل و پاس گل برای مسابقه
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<bool> Add(PlayerPerformanceRequestDto request);
}
