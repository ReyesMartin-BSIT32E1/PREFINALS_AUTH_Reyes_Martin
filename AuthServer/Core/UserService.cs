using Microsoft.AspNetCore.Identity;

namespace AuthServer.Core
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            // Check if the user exists
            var user = await _userRepository.GetUserAsync(username);
            if (user == null)
                return false; // User not found

            if (password == user.Password)
                return true;
            else
                return false;
        }

        public async Task<bool> RegisterUser(string username, string password)
        {
            // Check if the username is already taken
            var existingUser = await _userRepository.GetUserAsync(username);
            if (existingUser != null)
                return false; // Username already exists

            // Create a new user
            var newUser = new User
            {
                Username = username,
                Password = password
            };

            // Add the user to the repository
            return await _userRepository.AddUserAsync(newUser);
        }

    }
}
