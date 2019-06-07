using Microsoft.AspNetCore.Mvc;

namespace JG.FinTechTest.Controllers
{
    [Route("api/giftaid")]
    [ApiController]
    public class GiftAidController : ControllerBase
    {

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Hello World");
        }
    }
}
