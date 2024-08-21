using BTG.Credit.Ras.Interview.Domain.NotifySystem;

namespace BTG.Credit.Ras.Interview.Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public IEnumerable<NotificationType> ChannelsToNotify = [];
    }
}
