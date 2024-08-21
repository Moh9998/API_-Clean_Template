using Microsoft.AspNetCore.Mvc;

namespace API__Clean_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController(IWebHostEnvironment environment, IConfiguration configuration) : ControllerBase
    {
        private readonly IWebHostEnvironment _environment = environment;
        private readonly IConfiguration _configuration = configuration;

        // Get The environment Connection string
        [HttpGet("GetConnectionString")]
        public IActionResult GetConnectionString()
        {
            // Get the current environment name
            var environmentName = _environment.EnvironmentName;

            // Load the connection string from the configuration
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                return NotFound($"Connection string not found for environment: {environmentName}");
            }

            return Ok(new { Environment = environmentName, ConnectionString = connectionString });
        }
    }
}
