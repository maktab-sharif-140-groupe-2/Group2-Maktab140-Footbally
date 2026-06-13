
using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Entity;

namespace Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;

public class PlayerPerformance : BaseEntity
{
    public PlayerPerformance(int matchId, int goalPlayerId, int assistPlayerId)
    {
        MatchId = matchId;
        GoalPlayerId = goalPlayerId;
        AssistPlayerId = assistPlayerId;
    }

    public int MatchId { get; private set; }
    public int GoalPlayerId { get; private set; }
    public int AssistPlayerId { get; private set; }

    public Player GoalPlayer { get; private set; }
    public Player AssistPlayer { get; private set; }
    public Match Match { get; private set; }

    protected override void Validate()
    {
        throw new NotImplementedException();
    }
}
