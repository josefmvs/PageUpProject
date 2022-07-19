using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PageUpProject.Business;
using PageUpProject.Business.Interfaces;
using PageUpProject.Models;

namespace PageUpProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IParcelService _parcelService;

        public ValuesController(IParcelService parcelService)
        {
            _parcelService = parcelService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //HeavyParcelRuleFactory factory = new HeavyParcelRuleFactory();
            //int _order = RuleFactory.GetOrder(factory.CreateRule());
            var cost = _parcelService.ComputeCost(new Parcel());
            return new string[] { "value1", "value2" };
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
