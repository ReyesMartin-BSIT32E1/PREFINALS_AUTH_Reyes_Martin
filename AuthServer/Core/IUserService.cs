
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IUserService
    {
        Task<bool> ValidateCredentialsAsync(string username, string password);
        Task<bool> RegisterUser(string username, string password);

    }
}