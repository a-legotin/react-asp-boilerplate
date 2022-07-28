using Microsoft.AspNetCore.Mvc;

namespace Identity.Presenters
{
  public sealed class JsonContentResult : ContentResult
  {
    public JsonContentResult()
    {
      ContentType = "application/json";
    }
  }
}
