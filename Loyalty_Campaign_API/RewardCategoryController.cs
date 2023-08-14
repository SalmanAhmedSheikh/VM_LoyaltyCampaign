using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VM_LoyaltyCampaignAPI.Models;

namespace VM_LoyaltyCampaignAPI
{

    [Route("api/[controller]")]
    [ApiController]
    public class RewardCategoryController : ControllerBase
    {


        [HttpGet]
        [Route("GetRewardCategories")]
        public List<RewardCategories> GetRewardCategories()
        { return LoadList(); }




        private List<RewardCategories> LoadList()
        {
            List<RewardCategories> objList = new List<RewardCategories>();
            RewardCategories obj = new RewardCategories();
            obj.RewardCategoryName = "Gift Reward";
            objList.Add(obj);

            obj= new RewardCategories();
            obj.RewardCategoryName = "Discount Reward";
            objList.Add(obj);

            return objList;


        }
    }



}
