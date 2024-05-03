namespace AuthServer.Core
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string username);
        Task<bool> AddUserAsync(User user);
    }
}
