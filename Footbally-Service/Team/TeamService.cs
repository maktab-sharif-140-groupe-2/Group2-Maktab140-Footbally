
using Footbally_Common.Dto.Response.Team;
using Footbally_Domain.Entities.TeamEntity.Data;
using Footbally_Domain.Entities.TeamEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Service;

namespace Footbally_Service.Team;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;
    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<List<TableTeamResponseDto>> GetTableOfGroup(int groupNumber)
    {
        if (groupNumber > 12 || groupNumber < 1)
            throw new Exception("Invalid GroupNumber");

        var table= await _teamRepository.QueryAsync(x => new TableTeamResponseDto
        {
            Country = x.Country,
            Draw = x.Standing.Draw,
            GoalsAgainst = x.Standing.GoalsAgainst,
            GoalsFor = x.Standing.GoalsFor,
            Lose = x.Standing.Lost,
            Point = x.Standing.Points,
            Won = x.Standing.Won,
        }, x => x.GroupNumber == groupNumber);

        return table.OrderByDescending(x=> x.Point).ToList();

    }

    public async Task<TableTeamResponseDto> GetTableOfTeam(int teamId)
    {
        if (teamId > 48 || teamId < 1)
            throw new Exception("Invalid TeamId");

        var table = await _teamRepository.QueryAsync(x => new TableTeamResponseDto
        {
            Country = x.Country,
            Draw = x.Standing.Draw,
            GoalsAgainst = x.Standing.GoalsAgainst,
            GoalsFor = x.Standing.GoalsFor,
            Lose = x.Standing.Lost,
            Point = x.Standing.Points,
            Won = x.Standing.Won,
        }, x => x.Id == teamId);
        return table.First();
    }

    public async Task<TeamInformationResponseDto> GetTeamInformation(int teamId)
    {
        if (teamId > 48 || teamId < 1)
            throw new Exception("Invalid TeamId");

        var result= await _teamRepository.QueryAsync(x => new TeamInformationResponseDto
        {
            Country=x.Country,
            HeadCoach=x.CoachName,
            Players=x.Players.Select(x=> x.FirstName+" "+x.LastName).ToList(),
        });
        return result.First();

    }
}
