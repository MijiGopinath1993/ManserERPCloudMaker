using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class VouchersApiController : ControllerBase
    {
        // GET: api/<VouchersController>
        [HttpGet]
        public async Task<List<VoucherNames>> Get()
        {
            List<VoucherNames> voucherNames  = new List<VoucherNames>();
            using (var context = new CloudDBContext())
            {
                voucherNames = await context.Vouchernames.ToListAsync();
            }
            return voucherNames;
        }

        // GET api/<VouchersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<VouchersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VouchersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VouchersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
