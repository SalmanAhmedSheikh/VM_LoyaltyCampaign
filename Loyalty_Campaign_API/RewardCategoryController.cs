using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VM_LoyaltyCampaignAPI.Models;


using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace VM_LoyaltyCampaignAPI
{

    [Route("api/[controller]")]
    [ApiController]
    public class RewardCategoryController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public RewardCategoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetRewardCategories")]
        public List<RewardCategories> GetRewardCategories()
        { return LoadList(); }




        private List<RewardCategories> LoadList()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("UPS_GetAllRewardTypes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Console.WriteLine(dt.ToString());

            List<RewardCategories> objList = new List<RewardCategories>();
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i <dt.Rows.Count;i++)
                {
                    RewardCategories obj = new RewardCategories();
                    obj.RewardCategoryName =dt.Rows[i]["RewardCategory_Name"].ToString();
                    objList.Add(obj);
                }

            }



            return objList;


        }
    }



}
