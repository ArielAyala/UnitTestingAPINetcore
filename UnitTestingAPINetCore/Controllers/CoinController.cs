using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestingAPINetCore.Services;

namespace UnitTestingAPINetCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        private readonly ICoinService _coinService;

        public CoinController(ICoinService coinService)
        {
            _coinService = coinService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_coinService.Get());

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var coin = _coinService.Get(id);
            if(coin == null)
                return NotFound();

            return Ok(coin);
        }
    }
}
