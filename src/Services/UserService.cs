using Domain;
using Infrastructure.Repositories;
using Services.Requests;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICredentialsService _credentialsService;
        public UserService(
            IUserRepository userRepository,
            ICredentialsService credentialsService
        ) {
            _userRepository = userRepository;
            _credentialsService = credentialsService;
        }

        public User GetUser(string username)
        {
            return _userRepository.Get(username);
        }

        public CreateUserResponse AddUser(CreateUserRequest request)
        {
            var user = _userRepository.Get(request.Username);

            if (user != null)
            {
                return null;
            }

            string salt;

            var hash = _credentialsService.HashPassword(request.Password, out salt);

            _userRepository.Add(new User()
            {
                Username = request.Username,
                Hash = hash,
                Salt = salt
            });

            return new CreateUserResponse();
        }

        public bool ValidateLogin(string username, string password)
        {
            var user = _userRepository.Get(username);

            if (user != null)
            {
                return false;
            }

            if (!_credentialsService.VerifyPassword(password, user.Salt, user.Hash))
            {
                return false;
            }

            return true;
        }
    }
}
