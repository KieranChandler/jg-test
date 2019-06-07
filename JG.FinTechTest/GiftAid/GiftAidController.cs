using Microsoft.AspNetCore.Mvc;

namespace JG.FinTechTest.GiftAid
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
