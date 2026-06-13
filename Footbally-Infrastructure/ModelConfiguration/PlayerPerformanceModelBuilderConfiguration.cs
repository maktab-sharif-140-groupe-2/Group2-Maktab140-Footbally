using Footbally_Domain.Entities.PlayerPerformanceEntity.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbally_Infrastructure.ModelConfiguration
{
    public class PlayerPerformanceModelBuilderConfiguration : BaseModelConfiguration<PlayerPerformance>
    {
        protected override void ApplyEntityConfiguration(EntityTypeBuilder<PlayerPerformance> builder)
        {
            builder.HasQueryFilter(x => !x.GoalPlayer.IsDeleted&&!x.AssistPlayer.IsDeleted);
        }
    }
}
