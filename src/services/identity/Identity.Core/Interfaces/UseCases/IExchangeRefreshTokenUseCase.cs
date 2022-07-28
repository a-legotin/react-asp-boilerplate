using Core.UseCases;
using Identity.Core.Dto.UseCaseRequests;
using Identity.Core.Dto.UseCaseResponses;

namespace Identity.Core.Interfaces.UseCases
{
    public interface IExchangeRefreshTokenUseCase : IUseCaseRequestHandler<ExchangeRefreshTokenRequest, ExchangeRefreshTokenResponse>
    {
    }
}
