using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalProfileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("GetEducation")]
        public ActionResult<IEnumerable<string>> GetEducation()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetSkills")]
        public ActionResult<IEnumerable<string>> GetSkills()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetWorkExperience")]
        public ActionResult<IEnumerable<string>> GetWorkExperience()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetExtracurriculars")]
        public ActionResult<IEnumerable<string>> GetExtracurriculars()
        {
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
