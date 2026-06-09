using Footbally_Domain.Entities.CommonEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public abstract class BaseModelConfiguration<Tentity> : IEntityTypeConfiguration<Tentity> where Tentity : BaseEntity
{
    public void Configure(EntityTypeBuilder<Tentity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.CreatedAt);

        builder.HasQueryFilter(x => x.IsDeleted == false && x.DeletedAt == null);

        builder.Property(x => x.IsDeleted)
            .HasDefaultValue(false)
            .IsRequired(true);
        ApplyEntityConfiguration(builder);
    }
    protected abstract void ApplyEntityConfiguration(EntityTypeBuilder<Tentity> builder);


}
