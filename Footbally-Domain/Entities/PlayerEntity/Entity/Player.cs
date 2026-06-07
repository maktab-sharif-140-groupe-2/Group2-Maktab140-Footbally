
﻿using Footbally_Domain.Entities.CommonEntity.Entity;
using Footbally_Domain.Entities.PlayerEntity.Enums;
using Footbally_Domain.Entities.TeamEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbally_Domain.Entities.PlayerEntity.Entity
{
    public class Player : BaseEntity
    {
        public Player(string firstName, string lastName, string shirtNumber, string position, DateTime birthDate, int teamId)
        {
            FirstName = firstName;
            LastName = lastName;
            ShirtNumber = shirtNumber;
            Position = position;
            BirthDate = birthDate;
            TeamId = teamId;
            Validate();
        }
        #region Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ShirtNumber { get; private set; }
        public PositionEnum Position { get; private set; }
        public DateTime BirthDate { get; private set; }
        #endregion
        #region Navigation
        public Team Team { get; private set; }
        public int TeamId { get; private set; }
        #endregion
        protected override void Validate()
        {
            if (FirstName == null)
            {
                throw new ArgumentNullException("Invalid FirstName");
            }
            if (LastName == null)
            {
                throw new ArgumentNullException("Invalid LastName");
            }
            if (ShirtNumber == null)
            {
                throw new ArgumentNullException("Invalid ShirtNumber");
            }
           
            if (BirthDate >DateTime.UtcNow)
            {
                throw new ArgumentNullException("Invalid BirthDate");
            }

        }
    }
}
