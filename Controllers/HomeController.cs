using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {               

        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}