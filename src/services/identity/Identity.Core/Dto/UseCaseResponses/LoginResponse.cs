using System.Collections.Generic;
using Core.Dto;
using Core.UseCases;
using Identity.Core.Domain.Entities;

namespace Identity.Core.Dto.UseCaseResponses
{
    public class LoginResponse : UseCaseResponseMessage
    {
        public AccessToken AccessToken { get; }
        public string RefreshToken { get; }
        public User User { get; }
        public new IEnumerable<Error> Errors { get; }

        public LoginResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public LoginResponse(AccessToken accessToken, string refreshToken, User user, bool success = false, string message = null) : base(success, message)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            User = user;
        }
    }
}
