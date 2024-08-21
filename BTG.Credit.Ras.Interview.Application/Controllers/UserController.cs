using BTG.Credit.Ras.Interview.Application.Model;
using BTG.Credit.Ras.Interview.Domain.Users;
using BTG.Credit.Ras.Interview.Service;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserModel userModel)
        {
            var user = await _userService.CreateUserAsync(new User
            {
                ChannelsToNotify = userModel.ChannelsToNotify,
                Email = userModel.Email,
                Name = userModel.Name,
            });

            return Ok(user);
        }
    }
}
