namespace BTG.Credit.Ras.Interview.Application.Model
{
    public class NotificationModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IEnumerable<UserModel> UsersToNotify { get; set; } = [];

    }
}
