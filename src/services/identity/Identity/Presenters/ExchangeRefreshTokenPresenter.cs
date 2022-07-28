using System.Net;
using System.Text.Json;
using Core.UseCases;
using Identity.Core.Dto.UseCaseResponses;

namespace Identity.Presenters
{
    public sealed class ExchangeRefreshTokenPresenter : IOutputPort<ExchangeRefreshTokenResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ExchangeRefreshTokenPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(ExchangeRefreshTokenResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = response.Success ? JsonSerializer.Serialize(new Models.Response.ExchangeRefreshTokenResponse(response.AccessToken, response.RefreshToken)) : JsonSerializer.Serialize(response.Message);
        }
    }
}
