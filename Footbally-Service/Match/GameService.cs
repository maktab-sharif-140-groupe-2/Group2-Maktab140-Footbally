using Footbally_Common.Dto.Request.Game;
using Footbally_Common.Dto.Response.Game;
using Footbally_Common.Enums.Game;
using Footbally_Domain.Entities.GameEntity.Data;
using Footbally_Domain.Entities.GameEntity.Entity;
using Footbally_Domain.Entities.GameEntity.Service;
using Footbally_Domain.Entities.TeamEntity.Data;

namespace Footbally_Service.Match;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly ITeamRepository _teamRepository;

    public GameService(IGameRepository gameRepository, ITeamRepository teamRepository)
    {
        _gameRepository = gameRepository;
        _teamRepository = teamRepository;
    }

    public async Task<bool> Create(GameRequestDto gameRequestDto)
    {
        if (gameRequestDto.MatchDate < new DateTime(2026, 06, 11) || gameRequestDto.MatchDate > new DateTime(2026, 07, 19))
            throw new InvalidTimeZoneException("the Date is't in Correct time frame");
        var game=new Game(gameRequestDto.MatchDate,gameRequestDto.HomeTeamId,gameRequestDto.AwayTeamId
            ,gameRequestDto.HomeGoals,gameRequestDto.AwayGoals,gameRequestDto.status,gameRequestDto.stage);
       var result=await _gameRepository.AddAsync(game);
        if (!result)
            throw new ArgumentException("There is a problem, not created");
        return result;
    }

    public async Task<List<FutureGameResponseDto>> FutureGamesOfTeam(int teamId,int page,int pageSize)
    {
       var result=await _gameRepository.QueryAsync(x=> new FutureGameResponseDto
        {
            AwayTeam=x.AwayTeam.Country,
            Date=x.MatchDate,
            HomeTeam=x.HomeTeam.Country
        },x=>x.AwayTeamId==teamId||x.HomeTeamId==teamId,page,pageSize);
        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return  result;
    }

    public async Task<List<FutureGameResponseDto>> GamesPerDay(DateTime date)
    {
        if (date < new DateTime(2026, 06, 11) || date > new DateTime(2026, 07, 19))
            throw new InvalidTimeZoneException("the Date is't in Correct time frame");
        var result = await _gameRepository.QueryAsync(x => new FutureGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country
        }, x => x.MatchDate == date );
        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;

    }

    public async Task<List<PastGameResponseDto>> PastGamesOfTeam(int teamId, int page, int pageSize)
    {
        var result = await _gameRepository.QueryAsync(x => new PastGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country,
            Stage=x.Stage.ToString(),
            AwayGoals= x.AwayGoals,
            HomeGoals= x.HomeGoals,
            
        }, x => x.AwayTeamId == teamId || x.HomeTeamId == teamId, page, pageSize);
        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;
    }

    public async Task<List<FutureGameResponseDto>> ShowGamesGroupInformation(int groupNumber)
    {
      var teams=await  _teamRepository.QueryAsync(x=> x.Id,x=> x.GroupNumber == groupNumber);

      var result=  await _gameRepository.QueryAsync(x => new FutureGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country,
        }, x => teams.Contains(x.HomeTeamId) || teams.Contains(x.AwayTeamId) && x.Stage == Stage.Group);
        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;
    }

    public async Task<List<PastGameResponseDto>> ShowGamesGroupResult(int groupNumber)
    {
        var teams = await _teamRepository.QueryAsync(x => x.Id, x => x.GroupNumber == groupNumber);

        var result = await _gameRepository.QueryAsync(x => new PastGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country,
            Stage=x.Stage.ToString(),
            AwayGoals=x.AwayGoals,
            HomeGoals=x.HomeGoals,
        }, x => teams.Contains(x.HomeTeamId) || teams.Contains(x.AwayTeamId) && x.Stage == Stage.Group);

        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;
    }

    public async Task<List<FutureGameResponseDto>> ShowGamesStageInformation(Stage stage, int page, int pageSize)
    {
        var result = await _gameRepository.QueryAsync(x => new FutureGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country,
        }, x => x.Stage == Stage.Group, page, pageSize);

        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;
    }

    public async Task<List<PastGameResponseDto>> ShowGamesStageResult(Stage stage, int page, int pageSize)
    {
        var result = await _gameRepository.QueryAsync(x => new PastGameResponseDto
        {
            AwayTeam = x.AwayTeam.Country,
            Date = x.MatchDate,
            HomeTeam = x.HomeTeam.Country,
            Stage = x.Stage.ToString(),
            AwayGoals = x.AwayGoals,
            HomeGoals = x.HomeGoals,
        }, x =>  x.Stage == Stage.Group,page,pageSize);

        if (!result.Any())
            throw new Exception("Not Any Data For Present");
        return result;
    }

    public async Task<bool> UpdateGameStatus(int gameId,Status status,int homeGoal=0,int awayGoal=0)
    {
        return await _gameRepository.UpdateGameInfo(gameId, status, homeGoal, awayGoal);
    }
}
