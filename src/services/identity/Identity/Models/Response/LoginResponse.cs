using Identity.Core.Domain.Entities;
using Identity.Core.Dto;

namespace Identity.Models.Response
{
    public class LoginResponse
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }

        public User User { get; }
        public LoginResponse(AccessToken accessToken, string refreshToken, User user)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            User = user;
        }
    }
}
