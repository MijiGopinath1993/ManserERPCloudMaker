using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOpenBalanceApiController : ControllerBase
    {
        // GET: api/<CustomerOpenBalanceApiController>
        [HttpGet]
        public async Task<List<CustomerOpenBalance>> Get()
        {
            using (var context = new CloudDBContext())
            { 
                var custOpenBalance  = await (from custOB in context.Customeropenbalance
                                           select new CustomerOpenBalance
                                           {
                                               Id = custOB.Id,
                                               CustomerId = custOB.CustomerId,
                                               Date = custOB.Date,
                                               Location = custOB.Location,
                                               RefNo = custOB.RefNo,
                                               VoucherNo = custOB.VoucherNo,
                                               Type = custOB.Type,
                                               Amount = custOB.Amount,

                                           }).ToListAsync();

                return custOpenBalance;
            }
        }

        // GET api/<CustomerOpenBalanceApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerOpenBalanceApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(CustomerOpenBalance customerOpenBalance)
        {
            try
            {
                var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUser"));

                using (var context = new CloudDBContext())
                {
                    var _customerOpenBalance = new CustomerOpenBalance();
                     
                    _customerOpenBalance.CustomerId = customerOpenBalance.CustomerId;
                    _customerOpenBalance.Date = customerOpenBalance.Date;
                    _customerOpenBalance.Location = customerOpenBalance.Location;
                    _customerOpenBalance.RefNo = customerOpenBalance.RefNo;
                    _customerOpenBalance.VoucherNo = customerOpenBalance.VoucherNo;
                    _customerOpenBalance.Type = customerOpenBalance.Type;
                    _customerOpenBalance.Amount = customerOpenBalance.Amount;
                    _customerOpenBalance.CreatedOn = DateTime.Today;
                    _customerOpenBalance.CreatedBy = UserId;

                    context.Customeropenbalance.Add(_customerOpenBalance);
                    var result = await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw;

            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Open Balance Added Successfully!"
            };

        }


        // PUT api/<CustomerOpenBalanceApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerOpenBalanceApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Customeropenbalance.Where(s => s.Id == id).FirstOrDefault<CustomerOpenBalance>();
                    if (doc != null)
                    {
                        context.Customeropenbalance.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Opening Balance Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Opening Balance");
            }
        }
    }
}
