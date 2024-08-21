using BTG.Credit.Ras.Interview.Domain.Users;

namespace BTG.Credit.Ras.Interview.Domain
{
    public interface IEmailService
    {
        Task Send(string content, User user);
    }
}
