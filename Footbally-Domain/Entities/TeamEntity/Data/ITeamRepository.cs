using Footbally_Domain.Entities.CommonEntity.Data;
using Footbally_Domain.Entities.TeamEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbally_Domain.Entities.TeamEntity.Data
{
    public interface ITeamRepository:IGenericRepository<Team>
    {
    }
}
