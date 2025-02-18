namespace LogbookChineseEdition.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public ICollection<Role> Roles { get; set; } = null!;
    }
}
