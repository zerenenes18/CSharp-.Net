using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {


        [HttpGet]
        [Route("Sync")]
        public IActionResult GetSync()
        {
            Thread.Sleep(500);
            return Ok();
        }

        [HttpGet]
        [Route("Async")]
        
        public async Task<IActionResult> GetAsync()
        {
            await Task.Delay(1000);
            return Ok();
        }



    }
}
