using System.ComponentModel.DataAnnotations;

namespace Footbally_Common.Dto.Request.PlayerPerformance;

public class PlayerPerformanceRequestDto
{
    [Required(ErrorMessage ="MatchId Is Required")]
    [Range(1, int.MaxValue, ErrorMessage = "MatchId Can't Be Negative Or Zero")]
    public int MatchId { get; set; }

    [Required(ErrorMessage = "GoalPlayerId Is Required")]
    [Range(1, int.MaxValue, ErrorMessage = "GoalPlayerId Can't Be Negative Or Zero")]
    public int GoalPlayerId { get; set; }

    [Required(ErrorMessage = "AssistPlayerId Is Required")]
    [Range(1, int.MaxValue, ErrorMessage = "AssistPlayerId Can't Be Negative Or Zero")]
    public int AssistPlayerId { get; set; }

}
