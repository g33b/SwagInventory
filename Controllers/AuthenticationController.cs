using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwagInventory.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        [Route("/GetAccountInfo")]
        public IEnumerable<String> GetAccountInfo([FromQuery]string API_KEY)
        {
            return new List<String> { "No accounts found" };
        }
    }
}