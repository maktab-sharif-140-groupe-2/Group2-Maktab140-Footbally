using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Entity;

namespace Footbally_Domain.Entities.TeamEntity.Entity;

public class Team : BaseEntity
{
    public Team(string country, string coachName, int groupNumber)
    {
        Country = country;
        CoachName = coachName;
        GroupNumber = groupNumber;
        Validate();
    }

    public string Country { get; private set; }

    public string CoachName { get; private set; }

    public int GroupNumber { get; private set; }

    public List<Player> Players { get; private set; } = new();

    public List<Match> HomeMatches { get; private set; } = new();
    public List<Match> AwayMatches { get; private set; } = new();

    protected override void Validate()
    {
       
        if (string.IsNullOrWhiteSpace(Country))
            throw new ArgumentNullException("Country Name Can't Be Null");
        if (string.IsNullOrWhiteSpace(CoachName))
            throw new ArgumentNullException("CoachName Name Can't Be Null");
        if (CoachName.Length < 3)
            throw new InvalidDataException("Team Country Charcters Can't be Less 3");
        if (CoachName.Length < 6)
            throw new InvalidDataException("Team CoachName Charcters Can't be Less 6");
        if (GroupNumber < 1 || GroupNumber > 12)
            throw new InvalidOperationException("the group number must higher than 1 and lower than 12");

    }
}
