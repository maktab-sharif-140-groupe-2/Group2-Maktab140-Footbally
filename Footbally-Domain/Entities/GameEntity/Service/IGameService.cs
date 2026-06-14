using Footbally_Common.Dto.Request.Game;
using Footbally_Common.Dto.Response.Game;
using Footbally_Common.Enums.Game;

namespace Footbally_Domain.Entities.GameEntity.Service;

public interface IGameService
{
    Task<bool> Create(GameRequestDto gameRequestDto);

    Task<List<GameResponseDto>> GamesOfTeam(int  teamId);

    Task<List<GameResponseDto>> GamesPerDay(DateTime date);

    Task<List<GameResponseDto>> ShowGamesGroupInformation(int groupNumber);

    Task<List<GameResponseDto>> ShowGamesStageInformation(Stage stage);

    Task<bool> UpdateGameStatus(Status status);

}
