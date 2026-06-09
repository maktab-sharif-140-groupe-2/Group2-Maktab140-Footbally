using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Enums;
using Footbally_Domain.Entities.TeamEntity.Entity;

namespace Footbally_Domain.Entities.MatchEntity.Entity;

public class Match : BaseEntity
{
    public Match(DateTime matchDate, int homeTeamId, int awayTeamId, int homeGoals, int awayGoals,Status status,Stage stage)
    {
        MatchDate = matchDate;
        HomeGoals = homeGoals;
        AwayGoals = awayGoals;
        HomeTeamId = homeTeamId;
        AwayTeamId = awayTeamId;
        Status= status;
        Stage = stage;
        Validate();
    }


    #region
    public DateTime MatchDate { get; private set; }

    public int HomeGoals { get; private set; }

    public int AwayGoals { get; private set; }

    public Status Status { get; private set; }

    public Stage Stage { get; private set; }

    #endregion

    #region Foriegn Key
    public int HomeTeamId { get; private set; }

    public int AwayTeamId { get; private set; }
    #endregion

# region Naviration properties
    public virtual Team HomeTeam { get; private set; }

    public virtual Team AwayTeam { get; private set; }
    #endregion
    protected override void Validate()
    {
        if (MatchDate < DateTime.UtcNow)
            throw new InvalidOperationException("the match date cannot be in the past");

        if (HomeGoals < 0)
            throw new InvalidOperationException("the home goals cannot be negative");

        if (AwayGoals < 0)
            throw new InvalidOperationException("the away goals cannot be negative");

        if (HomeTeamId < 1)
            throw new InvalidOperationException("the home team id goals cannot be negative or 0");

        if (AwayTeamId < 1)
            throw new InvalidOperationException("the away team id goals cannot be negative or 0");
    }
}
