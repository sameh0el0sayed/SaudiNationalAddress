using Microsoft.AspNetCore.Mvc;
using SaudiNationalAddress.Services;

namespace SaudiNationalAddress.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NationalAddressController : ControllerBase
    {
        private readonly NationalAddressService _service;

        public NationalAddressController(NationalAddressService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Search(string address)
        {
            var result = await _service.SearchAddress(address);

            return Content(result, "application/json");
        }
    }
}
