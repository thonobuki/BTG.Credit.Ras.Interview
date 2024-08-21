using BTG.Credit.Ras.Interview.Domain.Users;

namespace BTG.Credit.Ras.Interview.Domain.NotifySystem
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public IEnumerable<User> UsersToNotify { get; set; } = [];
    }
}
