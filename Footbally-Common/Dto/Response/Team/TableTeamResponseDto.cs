namespace Footbally_Common.Dto.Response.Team;

public class TableTeamResponseDto
{
    public string Country { get; set; }
    public int Won { get; set; }
    public int Lose { get; set; }
    public int Draw {  get; set; }
    public int GoalsFor { get; set; }
    public int GoalsAgainst { get; set; }
    public int Point { get; set; }
}
