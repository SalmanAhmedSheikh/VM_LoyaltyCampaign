using System.ComponentModel;

namespace VM_ConsumeAPI.Models
{
    public class LoyaltyViewModel
    {
        [DisplayName("Loyalty Tier Name")]
        public string LoyaltyTierName { get; set; }
    }
}
