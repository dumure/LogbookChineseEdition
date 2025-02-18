using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoAPI.Data;

public sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).HasMaxLength(maxStringSize);
        builder.HasMany(e => e.Users).WithMany(e => e.Roles);
    }
    public readonly int maxStringSize = 64;
}