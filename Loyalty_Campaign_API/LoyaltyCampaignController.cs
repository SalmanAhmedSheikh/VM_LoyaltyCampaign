using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Loyalty_Campaign_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyCampaignController : ControllerBase
    {
        // GET: api/<LoyaltyCampaignController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET: api/<LoyaltyCampaignController>/GetLoyaltyTiers
        [HttpGet("GetLoyaltyTiers")]
        public IEnumerable<string> GetLoyaltyTiers()
        {
            return new string[] { "Gold", "Silver","Platinium" };
        }

        

    }
}
