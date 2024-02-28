using IndianaJones.Business.Abstract;
using IndianaJones.Business.Concrete;
using IndianaJones.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndianaJones.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IJQAController : ControllerBase
    {
        private IIndianaJonesService _indianaJonesService;

        public IJQAController()
        {
            _indianaJonesService = new IndianaJonesManager();
        }




        [HttpGet]
        public List<QA> GetQA()
        {
            return _indianaJonesService.GetAllQAs();
        }

        [HttpGet("{id}")]
        public QA GetQA(int id)
        {
            return _indianaJonesService.GetQAById(id);
        }


        [HttpPost]
        public QA PostQA([FromBody] QA qA)
        {
            return _indianaJonesService.CreateQA(qA);
        }

        [HttpPut]
        public QA PutQA([FromBody] QA qA)
        {
            return _indianaJonesService.UpdateQA(qA);
        }

        [HttpDelete("{id}")]
        public void DeleteQA(int id)
        {
            _indianaJonesService.DeleteQA(id);
        }
    }
}
