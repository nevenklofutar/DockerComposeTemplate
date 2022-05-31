using Api.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IApplicationRepository repository;

        public PeopleController(IApplicationRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllPeople()
        { 
            var result = repository.GetAllPeople();
            return Ok(result);
        }

        [HttpGet("{personId}")]
        public IActionResult GetPersonById(int personId)
        {
            var result = repository.GetPersonById(personId);
            return Ok(result);
        }
    }
}
