using BTG.Credit.Ras.Interview.Domain;
using BTG.Credit.Ras.Interview.Domain.NotifySystem;

namespace BTG.Credit.Ras.Interview.Service.NotifySystem
{
    public class NotificationService(IEmailService emailService) : INotificationService
    {
        private readonly IEmailService _emailService = emailService;

        public Task Notify(IEnumerable<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                foreach (var user in notification.UsersToNotify)
                {
                    _emailService.Send($@"
                        {notification.Title}
                        {notification.Description}
                    ", user);
                }
            }

            return Task.CompletedTask;
        }
    }
}
