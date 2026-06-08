using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.LeagueEntity.Enums;
using System;

namespace Footbally_Domain.Entities.LeagueEntity.Entity;

public class Leauge : BaseEntity
{
    public Leauge(string name, string country, LeaugeLevle levle)
    {
        Name = name;
        Country = country;
        Levle = levle;
        Validate();
    }

    public string Name { get; private set; }

    public string Country { get; private set; }

    public LeaugeLevle Levle { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new ArgumentNullException("Leauge Name Can't Be Null");
        if (string.IsNullOrWhiteSpace(Country))
            throw new ArgumentNullException("Country Leauge Name Can't Be Null");
        if (Country.Length < 3)
            throw new InvalidDataException("Leauge Country Name Charcters Can't be Less 3");

    }
}
