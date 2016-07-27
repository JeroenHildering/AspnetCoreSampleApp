using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreSampleApp.Controllers
{
    [Route("api/[controller]"), Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World! [Asp.NET Core]";
        }
    }
}
