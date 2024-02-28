using IndianaJones.Business.Abstract;
using IndianaJones.Business.Concrete;
using IndianaJones.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndianaJones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IJRewardsController : ControllerBase
    {
        private IIndianaJonesService _indianaJonesService;

        public IJRewardsController()
        {
            _indianaJonesService = new IndianaJonesManager();
        }




        [HttpGet]
        public List<Rewards> GetReward()
        {
            return _indianaJonesService.GetAllRewards();
        }

        [HttpGet("{id}")]
        public Rewards GetReward(int id)
        {
            return _indianaJonesService.GetRewardById(id);
        }


        [HttpPost]
        public Rewards PostReward([FromBody] Rewards reward)
        {
            return _indianaJonesService.CreateReward(reward);
        }

        [HttpPut]
        public Rewards PutReward([FromBody] Rewards reward)
        {
            return _indianaJonesService.UpdateReward(reward);
        }

        [HttpDelete("{id}")]
        public void DeleteReward(int id)
        {
            _indianaJonesService.DeleteReward(id);
        }
    }
}
