using LogbookChineseEdition.Entity;

namespace LogbookChineseEdition.Services
{
    public interface IUserContext
    {
        Task AddAsync(User user);
        Task DeleteAsync(User user);
        Task<User> GetAsync(int id);   
        Task<int> CountAsync();
    }
}
