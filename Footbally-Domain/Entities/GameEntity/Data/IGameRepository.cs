using Footbally_Common.Enums.Game;
using Footbally_Domain.Entities.CommonEntity.Data;
using Footbally_Domain.Entities.GameEntity.Entity;

namespace Footbally_Domain.Entities.GameEntity.Data;
public interface IGameRepository:IGenericRepository<Game>
{
    Task<bool> UpdateGameInfo(int gameId,Status status ,int homeGoal, int awayGoal);
}
