namespace LogbookChineseEdition.Entity
{
    public class GroupStudent
    {
        public int? Id_Group { get; set; }
        public Group? Group { get; }

        public int? Id_Student { get; set; }
        public Student? Student { get; set; }
    }
}
