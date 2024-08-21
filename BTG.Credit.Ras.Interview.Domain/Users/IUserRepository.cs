namespace BTG.Credit.Ras.Interview.Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
        Task<User> Add(User user);
        Task SaveAsync();
    }
}
