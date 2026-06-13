
using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Enums;
using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;
using Footbally_Domain.Entities.TeamEntity.Entity;

namespace Footbally_Domain.Entities.PlayerEntity.Entity
{
    public class Player : BaseEntity
    {
        private Player()
        {
            
        }
        public Player(string firstName, string lastName, string shirtNumber, PositionEnum position, int age, int teamId)
        {
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            ShirtNumber = shirtNumber.Trim();
            Position = position;
            Age = age;
            TeamId = teamId;
            Validate();
        }
        #region Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ShirtNumber { get; private set; }
        public PositionEnum Position { get; private set; }
        public int Age { get; private set; }
        #endregion

        #region ForeginKey
        public int TeamId { get; private set; }
        #endregion

        #region Navigation
        public Team Team { get; private set; }

        public List<PlayerPerformance> Goals { get; private set; }
        public List<PlayerPerformance> Assists { get; private set; }
        #endregion

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                throw new ArgumentNullException("Invalid First Name");

            if (FirstName.Length < 0 || FirstName.Length > 50)
                throw new InvalidOperationException("the firstName lenght must be higher than 0 and loweer than 50");

            if (string.IsNullOrWhiteSpace(LastName))
                throw new ArgumentNullException("Invalid LastName");

            if (LastName.Length < 0 || LastName.Length > 50)
                throw new InvalidOperationException("the LastName lenght must be higher than 0 and loweer than 50");

            if (string.IsNullOrWhiteSpace(ShirtNumber))
                throw new ArgumentNullException("Invalid ShirtNumber");

            if (ShirtNumber.Length > 2)
                throw new ArgumentNullException("ShirtNumber Charcters Can't be Higher 2");

            if (Convert.ToInt32(ShirtNumber) < 0)
                throw new ArgumentNullException("ShirtNumber Can't be Negative");

            if (Age < 0)
                throw new ArgumentOutOfRangeException("value cannot be negative");

            if (TeamId < 0)
                throw new ArgumentOutOfRangeException("value cannot be negative");
     

        }


    }
}
