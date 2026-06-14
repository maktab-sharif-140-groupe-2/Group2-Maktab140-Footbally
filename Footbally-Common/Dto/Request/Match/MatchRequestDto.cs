using Footbally_Domain.Entities.MatchEntity.Enums;
using System.Net.NetworkInformation;

namespace Footbally_Common.Dto.Request.Match;

public class MatchRequestDto
{
    public int HomeTeamId { get; set; }
    public int AwayTeamId { get; set; }
    public int HomeGoals { get; set; }
    public int AwayGoals { get; set; }
    public Status status { get; set; }
    public Stage stage { get; set; }
    public DateTime MatchDate { get; set; }

}
