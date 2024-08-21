namespace BTG.Credit.Ras.Interview.Domain.NotifySystem
{
    public interface INotificationService
    {
        Task Notify(IEnumerable<Notification> notifications);
    }
}
