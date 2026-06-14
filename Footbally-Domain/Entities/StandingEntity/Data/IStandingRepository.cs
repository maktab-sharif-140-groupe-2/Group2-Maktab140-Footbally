using Footbally_Common.Enums.Standing;
using Footbally_Domain.Entities.CommonEntity.Data;
using Footbally_Domain.Entities.StandingEntity.Entity;

namespace Footbally_Domain.Entities.StandingEntity.Data;

public interface IStandingRepository:IGenericRepository<Standing>
{
    Task UpdateStandingStatus(Standing standing,GameResult gameResult,int goalsFor,int goalsAgainst);
}
