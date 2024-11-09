using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        // GET: api/<CustomerApiController>
        [HttpGet]
        public async Task<List<Customers>> Get()
        { 
            List<Customers> lstCustomersdetails = new List<Customers>();
            //var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUserID"));

            using (var context = new CloudDBContext())
            {
                lstCustomersdetails = await context.Customers.ToListAsync();
            }
            return lstCustomersdetails;
        }


        // GET api/<CustomerApiController>/5
        [HttpGet("{id}")]
        public async Task<Customers> Get(int id)
        {
            Customers lstCustomers = new Customers();
            using (var context = new CloudDBContext())
            {
                lstCustomers = context.Customers.Where(s => s.Id == id).FirstOrDefault<Customers>();
            }
            return lstCustomers;
        }

        // POST api/<CustomerApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(Customers customers) 
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var existingUser = await context.Customers.Where(x => x.CustomerName == customers.CustomerName).FirstOrDefaultAsync();
                    if (existingUser != null)
                    {
                        var _response = new UserCreateResponseRP
                        {
                            Status = false,
                            UserID = -1,
                            Message = existingUser.CustomerName == customers.CustomerName ? "Customer Name already exists." : ""
                        };
                        return _response;
                    }
                    var existingCustCode  = await context.Customers.Where(x => x.CustomerCode == customers.CustomerCode).FirstOrDefaultAsync();
                    if (existingUser != null)
                    {
                        var _response = new UserCreateResponseRP
                        {
                            Status = false,
                            UserID = -1,
                            Message = existingUser.CustomerCode == customers.CustomerCode ? "Customer Code already exists." : ""
                        };
                        return _response;
                    }
                    var _customers = new Customers();
                    _customers.CustomerCode = customers.CustomerCode;
                    _customers.AccountCode = customers.AccountCode;
                    _customers.CustomerName = customers.CustomerName;                     
                    _customers.Accounttype = customers.Accounttype;                     
                    _customers.Emailid = customers.Emailid;                     
                    _customers.IsActive = customers.IsActive; 

                    context.Customers.Add(_customers);
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
                Message = "Customer Created Successfully!"
            };

        }

        // PUT api/<CompanyApiController>/5 
        public async Task<UserCreateResponseRP> Put(Customers customers)
        {
            using (var context = new CloudDBContext())
            {
                Customers _customers = context.Customers.FirstOrDefault(item => item.Id == customers.Id);

                // Validate entity is not null
                if (_customers != null)
                {
                    _customers.CustomerCode = customers.CustomerCode;
                    _customers.AccountCode = customers.AccountCode;
                    _customers.CustomerName = customers.CustomerName;
                    _customers.Type = customers.Type;
                    _customers.Customergroup = customers.Customergroup;
                    _customers.Accounttype = customers.Accounttype;
                    _customers.Currency = customers.Currency;
                    _customers.Allowcostcentre = customers.Allowcostcentre;
                    _customers.Tin = customers.Tin;
                    _customers.VatNumber = customers.VatNumber;
                    _customers.Iscomposition = customers.Iscomposition;
                    _customers.Aadharnumber = customers.Aadharnumber;
                    _customers.Address = customers.Address;
                    _customers.Location = customers.Location;
                    _customers.State = customers.State;
                    _customers.Country = customers.Country;
                    _customers.Postalcode = customers.Postalcode;
                    _customers.Telnumber = customers.Telnumber;
                    _customers.Faxnumber = customers.Faxnumber;
                    _customers.Emailid = customers.Emailid;
                    _customers.Website = customers.Website;

                    _customers.UploadImageName = customers.UploadImageName;
                    _customers.creditlimit = customers.creditlimit;
                    _customers.payterms = customers.payterms;
                    _customers.Defaultdiscount = customers.Defaultdiscount;
                    _customers.Pricelevel = customers.Pricelevel;
                    _customers.monthlybudget = customers.monthlybudget;

                    _customers.ContactpersonName = customers.ContactpersonName;
                    _customers.Designation = customers.Designation;
                    _customers.ConperTelnumber = customers.ConperTelnumber;
                    _customers.MobileNo = customers.MobileNo;
                    _customers.ConperEmailId = customers.ConperEmailId;

                    _customers.Allowsendsms = customers.Allowsendsms;
                    _customers.Allowsendemail = customers.Allowsendemail;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Customer updated Successfully!"
            };
        }


        // DELETE api/<CustomerApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Customers.Where(s => s.Id == id).FirstOrDefault<Customers>();
                    if (doc != null)
                    {
                        context.Customers.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Customer");
            }
        }
    }
}
