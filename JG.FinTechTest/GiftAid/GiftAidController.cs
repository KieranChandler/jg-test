using Microsoft.AspNetCore.Mvc;

namespace JG.FinTechTest.GiftAid
{
    [Route("api/giftaid")]
    [ApiController]
    public class GiftAidController : ControllerBase
    {
        private readonly GetGiftAidQuery _getGiftAidQuery;

        public GiftAidController(GetGiftAidQuery getGiftAidQuery)
        {
            _getGiftAidQuery = getGiftAidQuery;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] decimal amount)
        {
            return Ok(
                _getGiftAidQuery.Query(new GetGiftAidQueryRequest
                {
                    PrincipalAmount = amount
                }));
        }
    }
}
