using System.Threading.Tasks;
using Identity.Core.Dto;

namespace Identity.Core.Interfaces.Services
{
    public interface IJwtFactory
    {
        Task<AccessToken> GenerateEncodedToken(string id, string userName);
    }
}
