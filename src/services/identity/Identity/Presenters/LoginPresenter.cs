using System.Net;
using System.Text.Json;
using Core.UseCases;
using Identity.Core.Dto.UseCaseResponses;

namespace Identity.Presenters
{
    public sealed class LoginPresenter : IOutputPort<LoginResponse>
    {
        public JsonContentResult ContentResult { get; }

        public LoginPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(LoginResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            ContentResult.Content = response.Success ? JsonSerializer.Serialize(new Models.Response.LoginResponse(response.AccessToken, response.RefreshToken, response.User)) : JsonSerializer.Serialize(response.Errors);
        }
    }
}
