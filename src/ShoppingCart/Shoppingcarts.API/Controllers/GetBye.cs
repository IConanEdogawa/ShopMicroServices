using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shoppingcarts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBye : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Bye";
        }
    }
}
