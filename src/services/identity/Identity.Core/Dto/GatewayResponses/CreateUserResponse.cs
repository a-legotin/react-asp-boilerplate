using System.Collections.Generic;
using Core.Dto;
using Core.GatewayResponses;

namespace Identity.Core.Dto.GatewayResponses
{
  public sealed class CreateUserResponse : BaseGatewayResponse
  {
    public string Id { get; }
    public CreateUserResponse(string id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
    {
      Id = id;
    }
  }
}
