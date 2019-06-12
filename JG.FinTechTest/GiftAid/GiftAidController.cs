using System.Threading.Tasks;
using JG.FinTechTest.GiftAid.Donations;
using Microsoft.AspNetCore.Mvc;

namespace JG.FinTechTest.GiftAid
{
    [Route("api/giftaid")]
    [ApiController]
    public class GiftAidController : ControllerBase
    {
        private readonly GetGiftAidQuery _getGiftAidQuery;
        private readonly DonationReceivedCommandHandler _donationReceivedCommandHandler;

        public GiftAidController(GetGiftAidQuery getGiftAidQuery, DonationReceivedCommandHandler donationReceivedCommandHandler)
        {
            _getGiftAidQuery = getGiftAidQuery;
            _donationReceivedCommandHandler = donationReceivedCommandHandler;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetGiftAidApiRequest request)
        {
            return Ok(
                _getGiftAidQuery.Query(new GetGiftAidQueryRequest
                {
                    PrincipalAmount = request.Amount
                }));
        }

        [HttpPost("donation")]
        public async Task<IActionResult> NewDonation([FromBody] NewDonationRequest request)
        {
            await _donationReceivedCommandHandler.HandleAsync(
                new DonationReceivedCommand
                {
                    Name = request.Name,
                    PostCode = request.PostCode,
                    DonationAmount = request.DonationAmount
                });

            return Ok();
        }
    }
}
