using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IServiceStudent ServiceStudent;
        public StudentsController(IServiceStudent ServiceStudents)
        {
            this.ServiceStudent = ServiceStudents;
        }
        // GET api/temperatura
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return ServiceStudent.GetAll();
        }

        // GET api/temperatura/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return ServiceStudent.Get(id);
        }

        // POST api/temperatura
        [HttpPost]
        public void Post([FromBody] Student temperatura)
        {
            ServiceStudent.Save(temperatura);
        }

        // PUT api/temperatura/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student temperatura)
        {
            ServiceStudent.Save(temperatura);
        }

        // DELETE api/temperatura/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ServiceStudent.Delete(id);
        }
    }
}
