using BTG.Credit.Ras.Interview.Application.Model;
using BTG.Credit.Ras.Interview.Domain.NotifySystem;
using BTG.Credit.Ras.Interview.Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("[controller]")]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send")]
        public IActionResult Send([FromBody] IEnumerable<NotificationModel> notificationModels)
        {
            _notificationService.Notify(notificationModels.Select(x => new Notification
            {
                Description = x.Description,
                Title = x.Title,
                UsersToNotify = x.UsersToNotify.Select(x => new User
                {
                    ChannelsToNotify = x.ChannelsToNotify,
                    Email = x.Email,
                    Name = x.Name,
                })
            }));

            return Ok();
        }
    }
}
