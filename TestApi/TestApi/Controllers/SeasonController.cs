using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeasonController : ControllerBase
    {
        private readonly ILogger<SeasonController> _logger;

        public SeasonController(ILogger<SeasonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSeasons")]
        public IEnumerable<Season> Get()
        {
            Season season1 = new(1, "Winter");
            Season season2 = new(2, "Spring");

            List<Season> seasons = new List<Season>
            {
                season1,
                season2,
            };

            return seasons;
        }
    }
}