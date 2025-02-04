using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogbookChineseEdition.Data
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(maxStringSize);
            builder.Property(s => s.Surname).HasMaxLength(maxStringSize);
            builder.Property(s => s.FathersName).HasMaxLength(maxStringSize);
            builder.Property(s => s.Password).HasMaxLength(maxStringSize);
            builder.Property(s => s.BirthDate).HasColumnType("date");
            builder.Property(s => s.LastEntry).HasColumnType("date");
        }
        public readonly int maxStringSize = 64;
    }
}
