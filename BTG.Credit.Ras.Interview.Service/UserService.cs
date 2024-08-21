using BTG.Credit.Ras.Interview.Domain;
using BTG.Credit.Ras.Interview.Domain.Users;

namespace BTG.Credit.Ras.Interview.Service
{
    public class UserService : BaseService<IUserRepository>, IUserService
    {
        private readonly IEmailService _emailService;

        public UserService()
        {
            _emailService = new EmailService();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ValidationException("Name is required");
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ValidationException("Email is required");
            }

            if (!user.ChannelsToNotify.Any())
            {
                throw new ValidationException("ChannelsToNotify is required");
            }

            var anotherUser = await _repository.GetUserByEmailAsync(user.Email);
            if (anotherUser is not null)
            {
                throw new ValidationException($"Exists another user with e-mail '{user.Email}'");
            }

            await _repository.Add(user);
            await _repository.SaveAsync();  

            await _emailService.Send("User registred", user);

            return user;
        }
    }
}
