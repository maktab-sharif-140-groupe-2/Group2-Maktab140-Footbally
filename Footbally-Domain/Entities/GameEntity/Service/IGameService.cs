using Footbally_Common.Dto.Request.Game;
using Footbally_Common.Dto.Response.Game;
using Footbally_Common.Enums.Game;

namespace Footbally_Domain.Entities.GameEntity.Service;

public interface IGameService
{
    Task<bool> Create(GameRequestDto gameRequestDto);

    Task<List<FutureGameResponseDto>> FutureGamesOfTeam(int  teamId,int page,int pageSize);
    Task<List<PastGameResponseDto>> PastGamesOfTeam(int  teamId,int page,int pageSize);

    Task<List<FutureGameResponseDto>> GamesPerDay(DateTime date);

    Task<List<FutureGameResponseDto>> ShowGamesGroupInformation(int groupNumber);
    Task<List<PastGameResponseDto>> ShowGamesGroupResult(int groupNumber);

    Task<List<FutureGameResponseDto>> ShowGamesStageInformation(Stage stage,int page,int pageSize);
    Task<List<PastGameResponseDto>> ShowGamesStageResult(Stage stage,int page,int pageSize);

    Task<bool> UpdateGameStatus(int gameId,Status status,int homeGoal=0,int awayGoal=0);

}
