
﻿using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Enums;
using Footbally_Domain.Entities.TeamEntity.Entity;

namespace Footbally_Domain.Entities.PlayerEntity.Entity
{
    public class Player : BaseEntity
    {
        public Player(string firstName, string lastName, string shirtNumber, PositionEnum position, int age, int teamId)
        {
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
            ShirtNumber = shirtNumber.Trim();
            Position = position;
            Age = age;
            TeamId = teamId;
            Goals = 0;
            Assist = 0;
            Validate();
        }
        #region Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ShirtNumber { get; private set; }
        public PositionEnum Position { get; private set; }
        public int Age { get; private set; }
        public int Goals { get ; private set; }
        public int Assist { get ; private set; }
        #endregion

        #region ForeginKey
        public int TeamId { get; private set; }
        #endregion

        #region Navigation
        public Team Team { get; private set; }
        #endregion

        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentNullException("Invalid First Name");
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentNullException("Invalid LastName");
            }
            if (string.IsNullOrWhiteSpace(ShirtNumber))
            {
                throw new ArgumentNullException("Invalid ShirtNumber");
            }
            if (ShirtNumber.Length > 2)
            {
                throw new ArgumentNullException("ShirtNumber Charcters Can't be Higher 2");
            }
            if (Convert.ToInt32(ShirtNumber)<0)
            {
                throw new ArgumentNullException("ShirtNumber  Can't be Negative");
            }

        }

        public Player AddGoal()
        {
            Goals++;
            return this;
        }

        public Player AddAssist()
        {
            Assist++;
            return this;
        }
    }
}
