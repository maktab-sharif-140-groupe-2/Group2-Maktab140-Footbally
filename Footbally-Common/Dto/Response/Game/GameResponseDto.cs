using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbally_Common.Dto.Response.Game
{
    public class GameResponseDto
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public string Status { get; set; }
        public string Stage { get; set; }

        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        public DateTime Date { get; set; }


    }
}
