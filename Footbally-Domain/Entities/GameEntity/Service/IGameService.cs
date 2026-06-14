using Footbally_Common.Dto.Request.Game;
using Footbally_Common.Dto.Response.Game;
using Footbally_Common.Enums.Game;

namespace Footbally_Domain.Entities.GameEntity.Service;

public interface IGameService
{
    /// <summary>
    ///  ایجاد یک مسابقه جدید
    /// </summary>
    /// <param name="gameRequestDto"></param>
    /// <returns></returns>
    Task<bool> Create(GameRequestDto gameRequestDto);
    /// <summary>
    /// نمایش بازی های اینده یک تیم خاص
    /// </summary>
    /// <param name="teamId"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<FutureGameResponseDto>> FutureGamesOfTeam(int  teamId,int page,int pageSize);
    /// <summary>
    /// نمایش نتایج بازی های یک تیم خاص
    /// </summary>
    /// <param name="teamId"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<PastGameResponseDto>> PastGamesOfTeam(int  teamId,int page,int pageSize);
    /// <summary>
    /// بازی های برنامه ریزی شده برای تاریخ مشخض شده
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    Task<List<FutureGameResponseDto>> GamesPerDay(DateTime date);
    /// <summary>
    /// نمایش تمام بازی های یک گروه
    /// </summary>
    /// <param name="groupNumber"></param>
    /// <returns></returns>
    Task<List<FutureGameResponseDto>> ShowGamesGroupInformation(int groupNumber);
    /// <summary>
    /// نمایش نتایج بازی های انجام شده در یک گروه
    /// </summary>
    /// <param name="groupNumber"></param>
    /// <returns></returns>
    Task<List<PastGameResponseDto>> ShowGamesGroupResult(int groupNumber);
    /// <summary>
    /// نمایش تمام بازی های یک مرحله مشخص
    /// </summary>
    /// <param name="stage"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<FutureGameResponseDto>> ShowGamesStageInformation(Stage stage,int page,int pageSize);
    /// <summary>
    /// نمایش نتایج بازی های یک مرحله مشخص
    /// </summary>
    /// <param name="stage"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<List<PastGameResponseDto>> ShowGamesStageResult(Stage stage,int page,int pageSize);
    /// <summary>
    /// بروزرسانی اطلاعات یک مسابقه ثبت شده
    /// </summary>
    /// <param name="gameId"></param>
    /// <param name="status"></param>
    /// <param name="homeGoal"></param>
    /// <param name="awayGoal"></param>
    /// <returns></returns>
    Task<bool> UpdateGameStatus(int gameId,Status status,int homeGoal=0,int awayGoal=0);

}
