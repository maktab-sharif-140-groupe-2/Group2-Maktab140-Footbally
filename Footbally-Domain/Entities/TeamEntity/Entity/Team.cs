using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.MatchEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Entity;

namespace Footbally_Domain.Entities.TeamEntity.Entity;

public class Team : BaseEntity
{
    public Team( string country, string coachName)
    {
        Country = country;
        CoachName = coachName;
        Validate();
    }

    public string Country { get; private set; }

    public string CoachName { get; private set; }

    public List<Player> Players { get; private set; } = new();

    public List<Match> Matches { get; private set; } = new();

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
    }
}
