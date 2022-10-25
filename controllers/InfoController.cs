using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : Controller
    {
        [HttpGet]
        public JsonResult GetInfos()
        {
            return new JsonResult(new List<object>
            {
                new {id = 1, name = "Hello World"},
                new {id = 2, name = "Hello Netrokona"}
            });
        }
    }
}
