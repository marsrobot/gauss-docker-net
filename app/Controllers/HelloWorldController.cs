using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gauss_net.Controllers
{
    [ApiController]
    [Route("hello-world")]
    public class UserController : ControllerBase
    {
        private static Random rng = new Random();

        [HttpGet]
        public User Get([FromQuery(Name = "name")] string name)
        {
            long curr_id = rng.Next(0, 1000000000);
            string nameVal = "";
            if(string.IsNullOrEmpty(name)) {
                nameVal = "Hello Stranger";
            } else {
                nameVal = "Hello " + name;
            }

            return new User
            {
                Id = curr_id,
                Name = nameVal
            };
        }
    }
}
