using Data_People_C_Sharp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Data_People_C_Sharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService peopleService;

        public PeopleController(IPeopleService Service)
        {
            this.peopleService = Service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(peopleService.Get());

        [HttpGet("{id}")]

        public IActionResult GetByID(int id)
        {
            var people = peopleService.Get(id);

            if (people == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(people);

            }
        }
    }
}
