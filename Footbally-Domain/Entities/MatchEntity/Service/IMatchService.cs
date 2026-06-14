using Footbally_Common.Dto.Request.Match;
using Footbally_Common.Dto.Response.Match;
using Footbally_Domain.Entities.MatchEntity.Enums;

namespace Footbally_Domain.Entities.MatchEntity.Service;

public interface IMatchService
{
    Task<bool> Create(MatchRequestDto matchRequestDto);

    Task<List<MatchResponseDto>> MatchsOfTeam(int  teamId);

    Task<List<MatchResponseDto>> MatchPerDay(DateTime date);

    Task<List<MatchResponseDto>> ShowMatchsGroupInformation(int groupNumber);

    Task<List<MatchResponseDto>> ShowMatchsStageInformation(Stage stage);

    Task<bool> UpdateMatchStatus(Status status);

}
