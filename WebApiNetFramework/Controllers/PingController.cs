using System.Web.Http;

namespace WebApiNetFramework.Controllers
{
    public class PingController : ApiController
    {
        // GET: /api/ping
        [HttpGet]
        public IHttpActionResult Ping()
        {
            // Return a simple response indicating that the server is running
            return Ok("Web Application is running.");
        }
    }
}
