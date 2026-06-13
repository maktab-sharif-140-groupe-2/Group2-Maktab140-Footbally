
using Footbally_Domain.Entities.UserEntity.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Footbally_Infrastructure.ModelConfiguration;

public class UserModelBuilderConfiguration : BaseModelConfiguration<User>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.FullName)
            .IsRequired(true)
            .HasMaxLength(200);

        builder.Property(x => x.PhoneNumber)
            .IsRequired(true)
            .HasMaxLength(11);

        builder.HasIndex(x => x.PhoneNumber)
            .IsUnique();


    }
}
