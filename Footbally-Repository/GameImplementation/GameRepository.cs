using Footbally_Common.Enums.Game;
using Footbally_Domain.Entities.GameEntity.Data;
using Footbally_Domain.Entities.GameEntity.Entity;
using Footbally_Infrastructure.Common;
using Footbally_Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbally_Repository.GameImplementation
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        /// <summary>
        /// بروزرسانی مشخصات یک بازی ثبت شده
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="status"></param>
        /// <param name="homeGoal"></param>
        /// <param name="awayGoal"></param>
        /// <returns></returns>
        public async Task<bool> UpdateGameInfo(int gameId, Status status, int homeGoal, int awayGoal)
        {
            var game=await GetByIdAsync(gameId);
            if (game == null)
                return false;
            game.UpdateInfo(status, homeGoal, awayGoal);
            return await DbContext.SaveChangesAsync() > 0;
        }
    }
}
