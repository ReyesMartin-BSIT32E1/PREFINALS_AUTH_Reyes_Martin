using System;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public class AuthService : IAuthService
    {
        public async Task<string> GenerateJwtTokenAsync(string username)
        {
            // Here you would implement the logic to generate a JWT token based on the provided username
            // For demonstration purposes, let's just return a dummy token
            string token = await Task.FromResult(Guid.NewGuid().ToString());
            return token;
        }
    }
}