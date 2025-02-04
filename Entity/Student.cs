namespace LogbookChineseEdition.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string FathersName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public DateTime LastEntry { get; set; }
        public string Password { get; set; } = null!;
        public virtual IEnumerable<GroupStudent> GroupStudents { get; set; }

    }
}
