using IndianaJones.Business.Abstract;
using IndianaJones.Business.Concrete;
using IndianaJones.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndianaJones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IJPlayerController : ControllerBase
    {
        private IIndianaJonesService _indianaJonesService;

        public IJPlayerController()
        {
            _indianaJonesService = new IndianaJonesManager();
        }




        [HttpGet]
        public List<Player> GetPlayer()
        {
            return _indianaJonesService.GetAllPlayers();
        }

        [HttpGet("{id}")]
        public Player GetPlayer(int id)
        {
            return _indianaJonesService.GetPlayerById(id);
        }


        [HttpPost]
        public Player PostPlayer([FromBody]Player player)
        {
            return _indianaJonesService.CreatePlayer(player);
        }

        [HttpPut]
        public Player PutPlayer([FromBody] Player player)
        {
            return _indianaJonesService.UpdatePlayer(player);
        }

        [HttpDelete("{id}")]
        public void DeletePlayer(int id)
        {
            _indianaJonesService.DeletePlayer(id);
        }
    }
}
