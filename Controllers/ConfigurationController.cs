using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly ILogger<ConfigurationController> _logger;
        private readonly IConfiguration _configuration;

        public ConfigurationController(
            ILogger<ConfigurationController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
			_configuration = configuration;

		}

        [HttpGet]
        public ActionResult<string> GetConfiguration(string key)
        {
            var configuration = _configuration.GetValue<string>(key);

			return Ok(configuration);
        }
    }
}
