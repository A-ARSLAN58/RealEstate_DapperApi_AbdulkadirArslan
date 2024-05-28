using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_DapperApi_AbdulkadirArslan.Tools;

namespace RealEstate_DapperApi_AbdulkadirArslan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCreateController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToken(GetCheckAppUserViewModel model)
        {
            var values = JwtTokenGenerator.GenerateToken(model);
            return Ok(values);
        }
    }
}
