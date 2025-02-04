using LogbookChineseEdition.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogbookChineseEdition.Data
{
    public class GroupStudentConfiguration : IEntityTypeConfiguration<GroupStudent>
    {
        public void Configure(EntityTypeBuilder<GroupStudent> builder)
        {
            builder.HasKey(gs => new { gs.Id_Group, gs.Id_Student});

            builder.HasOne(gs => gs.Group).WithMany(g => g.GroupStudents).HasForeignKey(gs => gs.Id_Group);

            builder.HasOne(gs => gs.Student).WithMany(s => s.GroupStudents).HasForeignKey(gs => gs.Id_Student);
        }
    }
}
