namespace Footbally_Common.Dto.Request.PlayerPerformance;

public class PlayerPerformanceRequestDto
{
    public int MatchId { get; set; }
    public int GoalPlayerId { get; set; }
    public int AssistPlayerId { get; set; }

}
