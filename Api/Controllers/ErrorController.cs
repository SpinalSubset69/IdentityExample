using Api.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("errors/{statusCode}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController
    {
        public IActionResult Error(int statusCode){
            return new ObjectResult( new ApiResponse(statusCode));
        }
    }
}