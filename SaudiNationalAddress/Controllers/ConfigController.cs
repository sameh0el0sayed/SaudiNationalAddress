using Microsoft.AspNetCore.Mvc;

namespace SaudiNationalAddress.Controllers
{
    [ApiController]
    [Route("api/config")]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("google-key")]
        public IActionResult GetGoogleKey()
        {
            return Ok(new
            {
                ApiKey = _configuration["GoogleMaps:ApiKey"]
            });
        }
    }
}
