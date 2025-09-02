using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RanderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("getdata")]
        public IActionResult GetData()
        {
            var data = new
            {
                Message = "Hello, this is your data!",
                Timestamp = DateTime.UtcNow
            };
            return Ok(data);
        }
        [HttpPost("postdata")]
        public IActionResult PostData([FromBody] dynamic inputData)
        {
            if (inputData == null)
            {
                return BadRequest("No data provided.");
            }
            // Process the input data as needed
            return Ok(new { Status = "Data received successfully", Data = inputData });
        }
    }
}
