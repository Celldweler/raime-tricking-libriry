using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TrickingLibriry.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        public string Index()
        {
            return "Hello world!";
        }
    }
}
