using Footbally_Domain.Entities.MatchEntity.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Footbally_Common.Dto.Request.Match;

public class MatchRequestDto
{
    [Required(ErrorMessage = "HomeTeamId Is Required")]
    [Range(1, int.MaxValue,ErrorMessage = "HomeTeamId Can't Be Negative Or Zero")]
    public int HomeTeamId { get; set; }

    [Required(ErrorMessage = "AwayTeamId Is Required")]
    [Range(1, int.MaxValue, ErrorMessage = "AwayTeamId Can't Be Negative Or Zero")]
    public int AwayTeamId { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "HomeGoals Can't Be Negative ")]
    public int HomeGoals { get; set; }= 0;

    [Range(0, int.MaxValue, ErrorMessage = "AwayGoals Can't Be Negative ")]
    public int AwayGoals { get; set; } = 0;
    public Status status { get; set; }=Status.Scheduled;

    [Required(ErrorMessage = "Stage Is Required")]
    public Stage stage { get; set; }

    [Required(ErrorMessage = "MatchDate Is Required")]
    public DateTime MatchDate { get; set; }

}
