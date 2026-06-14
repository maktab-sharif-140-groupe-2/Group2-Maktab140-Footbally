using Footbally_Common.Dto.Response.Team;

namespace Footbally_Domain.Entities.TeamEntity.Service;
public interface ITeamService
{

   Task<List<TableTeamResponseDto>> GetTableOfGroup(int groupNumber);
   Task<List<TableTeamResponseDto>> GetTableOfTeam(int teamId);
    Task<List<TeamInformationResponseDto>> GetTeamInformation(int teamId);

}
