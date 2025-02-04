using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogbookChineseEdition.Data
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name).HasMaxLength(maxStringSize);
            builder.Property(g => g.FormationDate).HasColumnType("date");
        }
        public readonly int maxStringSize = 64;
    }
}
