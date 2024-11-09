using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisionsApiController : ControllerBase
    {
        // GET: api/<PermisionsApiController>
        [HttpGet]
        public async Task<List<Permisions>> Get()
        {
            List<Permisions> Permisionpages  = new List<Permisions>();
            using (var context = new CloudDBContext())
            {
                Permisionpages = await context.Permisions.ToListAsync();
            }
            return Permisionpages;
        }

        // GET api/<PermisionsApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermisionsApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PermisionsApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PermisionsApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
