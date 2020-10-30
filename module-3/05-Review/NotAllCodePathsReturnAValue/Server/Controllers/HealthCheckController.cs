using Microsoft.AspNetCore.Mvc;

namespace EmporiumServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        private readonly ICostumeDao costumeDao;

        public HealthCheckController(ICostumeDao costumeDao)
        {
            this.costumeDao = costumeDao;
        }

        /// <summary>
        /// This is an endpoint an automated tool might call to make sure the server is online.
        /// It exists for you to use to check that dependency injection is working properly.
        /// </summary>
        [HttpGet]
        public ActionResult<string> CheckHealth()
        {
            int numCostumes = costumeDao.GetAllCostumes().Length;

            return base.Ok($"Server online and {numCostumes} costume(s) detected.");
        }
    }
}
