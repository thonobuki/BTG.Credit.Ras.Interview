namespace BTG.Credit.Ras.Interview.Domain.Users
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
    }
}
