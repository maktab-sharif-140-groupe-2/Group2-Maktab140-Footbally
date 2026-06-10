using Footbally_Domain.Entities.CommonEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class BaseModelConfiguration<Tentity> : IEntityTypeConfiguration<Tentity> where Tentity : BaseEntity
{
    public void Configure(EntityTypeBuilder<Tentity> builder)
    {

    }
}
