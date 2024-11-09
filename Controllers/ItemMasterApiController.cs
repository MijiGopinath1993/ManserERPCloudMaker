using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterApiController : ControllerBase
    {
        // GET: api/<ItemMasterApiController>
        [HttpGet]
        public async Task<List<ItemMaster>> Get() 
        {
            List<ItemMaster> lstitemdetails = new List<ItemMaster>();
            //var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUserID")); 
            using (var context = new CloudDBContext())
            {
                lstitemdetails = await context.Productitems.ToListAsync();
            }
            return lstitemdetails; 
        }

        // GET api/<ItemMasterApiController>/5
        [HttpGet("{id}")]
        public async Task<ItemMaster> Get(int id)
        {
            ItemMaster itemdetails = new ItemMaster();
            using (var context = new CloudDBContext())
            {
                itemdetails = context.Productitems.Where(s => s.Id == id).FirstOrDefault<ItemMaster>();
            }
            return itemdetails;
        }
        // POST api/<ItemMasterApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItemMasterApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemMasterApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
