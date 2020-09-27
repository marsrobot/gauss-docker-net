using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.JsonPatch;
using System.Dynamic;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace gauss_net.Controllers
{
    [ApiController]
    [Route("sum")]
    public class SumController : ControllerBase
    {
        private static Random rng = new Random();

        [HttpPost]
        public IActionResult Post([FromBody] object body)
        {
            String patch = body.ToString();
            JObject jobj = JObject.Parse(patch);
            long x = jobj.GetValue("x").ToObject<long>();
            long y = jobj.GetValue("y").ToObject<long>();
            Dictionary<string, long> res = new Dictionary<string, long>();
            res["sum"] = x + y;
            return Ok(res);
        }
    }
}
