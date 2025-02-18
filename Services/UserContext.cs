using LogbookChineseEdition.Entity;

namespace LogbookChineseEdition.Services
{
    public class UserContext : IUserContext
    {
        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
