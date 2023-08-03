using CRUD.Repository;
using Microsoft.AspNetCore.Mvc;
using RegLibrary.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reg_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegController : ControllerBase
    {
        RegCrud obj;
        public RegController()
        {
            obj = new RegCrud();
        }
        // GET: api/<RegController>
        [HttpGet]
        public IEnumerable<RegModel> Get()
        {
            return obj.Select();
        }

        // GET api/<RegController>/5
        [HttpGet("{Id}")]
        public IEnumerable<RegModel> Get(int Id)
        {
            return obj.Select(Id);
        }

        // POST api/<RegController>
        [HttpPost]
        public void Post([FromBody] RegModel value)
        {
            obj.Insert(value);
        }

        // PUT api/<RegController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RegModel value)
        {
            value.Id = id;
            obj.Update(value);
        }

        // DELETE api/<RegController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.Delete(id);
        }
    }
}
