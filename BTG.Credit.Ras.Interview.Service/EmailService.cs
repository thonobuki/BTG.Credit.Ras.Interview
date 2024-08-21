using BTG.Credit.Ras.Interview.Domain;
using BTG.Credit.Ras.Interview.Domain.Users;
using System.Diagnostics;

namespace BTG.Credit.Ras.Interview.Service
{
    public class EmailService : IEmailService
    {
        public Task Send(string content, User user)
        {
            Debug.Write($"Sending e-mail to {user.Name}");
            return Task.CompletedTask;
        }
    }
}
