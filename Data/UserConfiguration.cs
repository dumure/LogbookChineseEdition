using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogbookChineseEdition.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Login).HasMaxLength(maxStringSize);
            builder.Property(s => s.Password).HasMaxLength(maxStringSize);
        }
        public readonly int maxStringSize = 64;
    }
}
