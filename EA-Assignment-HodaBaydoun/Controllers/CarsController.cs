using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EA;
using Microsoft.AspNetCore.Mvc;

namespace EA_Assignment_HodaBaydoun.Controllers
{
    [Route("v2/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarLogic logic = new CarLogic();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CarObj>> Get([FromQuery(Name = "start")] int start, [FromQuery(Name = "end")] int end, [FromQuery(Name = "lang")] string lang="en")
        {
            return Ok(new AppResponse<IEnumerable<CarObj>>(logic.GetAll(start, end, lang)));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
