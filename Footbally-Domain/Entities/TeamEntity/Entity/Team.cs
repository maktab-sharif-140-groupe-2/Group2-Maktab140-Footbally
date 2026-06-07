using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Entity;

namespace Footbally_Domain.Entities.TeamEntity.Entity;

public class Team : BaseEntity
{
    public int FoundedYear { get; private set; }
    public string City { get; private set; }
    public string CoachName { get; private set; }
    public Player Players { get; private set; } = new();

    protected override void Validate()
    {
        if (FoundedYear < 1857)
            throw new InvalidDataException("The Oldest Team In World FoundedYear Is 1857");
        if (string.IsNullOrWhiteSpace(City))
            throw new ArgumentNullException("Team City Name Can't Be Null");
        if (string.IsNullOrWhiteSpace(CoachName))
            throw new ArgumentNullException("Team City Name Can't Be Null");
        if (City.Length < 2)
            throw new InvalidDataException("Team City Charcters Can't be Less 2");
        if (CoachName.Length < 6)
            throw new InvalidDataException("Team CoachName Charcters Can't be Less 6");
    }
}
