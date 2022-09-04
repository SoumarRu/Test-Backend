using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPeople")]
        public IEnumerable<Person> Get()
        {
            Person person1 = new(1, "Soumar", 28);
            Person person2 = new(2, "Mehdi", 26);
            Person person3 = new(3, "Mohamed", 27);

            List<Person> persons = new List<Person>
            {
                person1,
                person2,
                person3
            };
            return persons;
        }
    }
}