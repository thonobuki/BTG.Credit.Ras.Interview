using BTG.Credit.Ras.Interview.Domain.Users;

namespace BTG.Credit.Ras.Interview.Data
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Add(User user)
        {
            user.Id = Guid.NewGuid();
            return Task.FromResult(user);
        }

        public Task<User?> GetUserByEmailAsync(string email)
        {
            return Task.FromResult(new User()
            {
                Email = email
            });
        }

        public Task SaveAsync()
        {
            return Task.CompletedTask;
        }
    }
}
