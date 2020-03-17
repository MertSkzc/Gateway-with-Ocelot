using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Customers = new[]
        {
            "Mert","Ali"
        };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Customers;
        }
    }
}