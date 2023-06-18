using Bilgi_Yon_Api.JWT;
using Microsoft.AspNetCore.Mvc;

namespace Bilgi_Yon_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenOlustur()
        {
            return Created("", new CreateToken().TokenCreate());
        }
    }
}
