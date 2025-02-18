using LogbookChineseEdition.Entity;

namespace LogbookChineseEdition.Services
{
    public interface IRoleContext
    {
        Task AddAsync(Role role);
        Task DeleteAsync(Role role);
        Task<Role> GetAsync(int id);
        Task<int> CountAsync();
    }
}
