using Footbally_Common.Dto.Request.Game;
using Footbally_Common.Dto.Response.Game;
using Footbally_Common.Enums.Game;
using Footbally_Domain.Entities.GameEntity.Data;
using Footbally_Domain.Entities.GameEntity.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Footbally_Service.Match;

public class GameService : IGameService
{
    private readonly IGameRepository _matchRepository;

    public GameService(IGameRepository matchRepository)
    {
        _matchRepository = matchRepository;
    }

  
 

    public Task<bool> Create(GameRequestDto gameRequestDto)
    {
        if (gameRequestDto.MatchDate < new DateTime(2026, 06, 11) || gameRequestDto.MatchDate > new DateTime(2026, 07, 19))
            throw new InvalidTimeZoneException("the Date is't in Correct time frame");
    }

    public Task<List<GameResponseDto>> GamesOfTeam(int teamId)
    {
        throw new NotImplementedException();

    }

    public Task<List<GameResponseDto>> GamesPerDay(DateTime date)
    {

        if (date < new DateTime(2026, 06, 11) || date > new DateTime(2026, 07, 19))
            throw new InvalidTimeZoneException("the Date is't in Correct time frame");
    }

    public Task<List<GameResponseDto>> ShowGamesGroupInformation(int groupNumber)
    {
        throw new NotImplementedException();
    }

    public Task<List<GameResponseDto>> ShowGamesStageInformation(Stage stage)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateGameStatus(Status status)
    {
        throw new NotImplementedException();
    }
}
