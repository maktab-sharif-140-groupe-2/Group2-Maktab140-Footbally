using Footbally_Common.Enums.Standing;
using Footbally_Domain.Entities.StandingEntity.Data;
using Footbally_Domain.Entities.StandingEntity.Service;

namespace Footbally_Service.Standing;

public class StandingService : IStandingService
{
    private readonly IStandingRepository _standingRepository;

    public StandingService(IStandingRepository standingRepository)
    {
        _standingRepository = standingRepository;
    }

    public async Task UpdateStandingInfo(int teamId, GameResult gameResult, int goalsFor = 0, int goalsAgainst = 0)
    {
        if (teamId > 48 || teamId < 1)
            throw new Exception("The Team Id Is Invalid");

       var result = await _standingRepository.QueryAsync(x=> x,x=>x.TeamId==teamId);
       var standing = result.FirstOrDefault();

        if (standing == null)
            throw new Exception("Not Exist this Standing");

       await _standingRepository.UpdateStandingStatus(standing, gameResult, goalsFor, goalsAgainst);

    }
}
