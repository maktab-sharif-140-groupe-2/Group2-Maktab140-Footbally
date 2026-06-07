using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.LeagueEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;

namespace Footbally_Domain.Entities.StandingEntity.Entity;

public class Standing : BaseEntity
{
    public Standing(int played, int won, int lost, int draw, int goalsFor, int goalsAgainst, int points, int leagueId, int teamId)
    {
        Played = played;
        Won = won;
        Lost = lost;
        Draw = draw;
        GoalsFor = goalsFor;
        GoalsAgainst = goalsAgainst;
        Points = points;
        LeagueId = leagueId;
        TeamId = teamId;

        Validate();
    }

    public int Played { get; private set; }

    public int Won  { get; private set; }

    public int Lost { get; private set; }

    public int Draw { get; private set; }

    public int GoalsFor { get; private set; }

    public int GoalsAgainst { get; private set; }

    public int Points { get; private set; }

    // Foriegn Key
    public int LeagueId { get; private set; }

    public int TeamId { get; private set; }

    // Navigation Properties
    public virtual Team Team { get; private set; }

    public virtual League League { get; private set; }

    protected override void Validate()
    {
        if (Played < 0)
            throw new InvalidOperationException("the Played cannot be negative");

        if (Won < 0)
            throw new InvalidOperationException("the Won cannot be negative");

        if (Lost < 0)
            throw new InvalidOperationException("the Lost cannot be negative");

        if (Draw < 0)
            throw new InvalidOperationException("the Draw cannot be negative");

        if (GoalsFor < 0)
            throw new InvalidOperationException("the GoalsFor cannot be negative");

        if (GoalsAgainst < 0)
            throw new InvalidOperationException("the GoalsAgainst cannot be negative");
    }
}
