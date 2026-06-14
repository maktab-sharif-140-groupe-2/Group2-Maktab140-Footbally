using Footbally_Common.Dto.Request.PlayerPerformance;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Data;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Service;

namespace Footbally_Service.PlayerPerformance;

public class PlayerPerformanceService : IPlayerPerformanceService
{
    private readonly IPlayerPerformanceRepository _playerPerformanceRepository;

    public PlayerPerformanceService(IPlayerPerformanceRepository playerPerformanceRepository)
    {
        _playerPerformanceRepository = playerPerformanceRepository;
    }

    public async Task<bool> Add(PlayerPerformanceRequestDto request)
    {
        if (request.AssistPlayerId == request.GoalPlayerId)
            throw new Exception("Goal And Assist Player Can't be One Person");

        var performance = new Footbally_Domain.Entities.PlayerPerformanceEntity.Entity.PlayerPerformance(request.MatchId, request.GoalPlayerId, request.AssistPlayerId);

        return await _playerPerformanceRepository.AddAsync(performance);
    }
}
