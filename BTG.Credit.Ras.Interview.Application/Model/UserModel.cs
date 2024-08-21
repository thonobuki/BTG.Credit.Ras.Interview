using BTG.Credit.Ras.Interview.Domain.NotifySystem;

namespace BTG.Credit.Ras.Interview.Application.Model
{
    public class UserModel
    {
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public IEnumerable<NotificationType> ChannelsToNotify { get; set; } = [];
    }
}
