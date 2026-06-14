using Footbally_Common.Dto.Response.Team;

namespace Footbally_Domain.Entities.TeamEntity.Service;
public interface ITeamService
{
    /// <summary>
    /// نمایش جدول ردبندی یک گروه مشخص
    /// </summary>
    /// <param name="groupNumber"></param>
    /// <returns></returns>
   Task<List<TableTeamResponseDto>> GetTableOfGroup(int groupNumber);
    /// <summary>
    /// نمایش اطلاعات جدولی یک تیم مشخض
    /// </summary>
    /// <param name="teamId"></param>
    /// <returns></returns>
   Task<TableTeamResponseDto> GetTableOfTeam(int teamId);

    /// <summary>
    /// نمایش اطلاعات یک تیم خاص
    /// </summary>
    /// <param name="teamId"></param>
    /// <returns></returns>
    Task<TeamInformationResponseDto> GetTeamInformation(int teamId);

}
