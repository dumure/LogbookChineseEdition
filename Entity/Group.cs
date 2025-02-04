namespace LogbookChineseEdition.Entity
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime FormationDate { get; set; }
        public virtual IEnumerable<GroupStudent> GroupStudents { get; set; }
    }
}
