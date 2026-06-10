using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;

namespace Footbally_Domain.Entities.StandingEntity.Entity;

public class Standing : BaseEntity
{
    public Standing(int teamId, int played = 0, int won = 0, int lost = 0, int draw = 0, int goalsFor = 0, int goalsAgainst = 0, int points = 0)
    {
        Played = played;
        Won = won;
        Lost = lost;
        Draw = draw;
        GoalsFor = goalsFor;
        GoalsAgainst = goalsAgainst;
        Points = points;
        TeamId = teamId;
        Validate();
    }

    public int Played { get; private set; }

    public int Won { get; private set; }

    public int Lost { get; private set; }

    public int Draw { get; private set; }

    public int GoalsFor { get; private set; }

    public int GoalsAgainst { get; private set; }

    public int Points { get; private set; }

    #region Foreign Key
    public int TeamId { get; private set; }
    #endregion

    public Standing SetWin(int goalsFor,int goalsAgainst)
    {
        Played++;
        Points += 3;
        Won++;
        GoalsFor += goalsFor;
        GoalsAgainst+=goalsAgainst;
        return this;
    }
    public Standing SetDraw(int goalsFor,int goalsAgainst)
    {
        Played++;
        Points += 1;
        Draw++;
        GoalsFor += goalsFor;
        GoalsAgainst+=goalsAgainst;
        return this;
    }
    public Standing SetLost(int goalsFor, int goalsAgainst)
    { 
        Played++;
        Lost++;
        GoalsFor += goalsFor;
        GoalsAgainst+=goalsAgainst;
        return this;
    }



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
