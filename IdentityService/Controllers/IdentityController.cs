using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private static readonly string[] privateKey = new[]
        {
            "This is your API-Key = Key-123456789"
        };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return privateKey;
        }
    }
}