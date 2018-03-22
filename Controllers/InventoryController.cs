using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwagInventory.Controllers
{
    [Produces("application/json")]
    [Route("api/Inventory")]
    public class InventoryController : Controller
    {

        [HttpGet]
        [Route("/Search")]
        public IEnumerable<String> Search([FromQuery]string keywords)
        {
            return new List<String> { "No products found!" };
        }


        [HttpGet]
        [Route("/GetInfoByID")]
        public IEnumerable<String> GetInfoByID([FromQuery]string keywords)
        {
            return new List<String> { "NO INFO FOUND!" };
        }


    }
}