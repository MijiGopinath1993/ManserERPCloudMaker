using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LedgersApiController : ControllerBase
    {
        // GET: api/<LedgersApiController>
        [HttpGet]
        public async Task<List<Ledgers>> Get()
        {
            List<Ledgers> ledgers = new List<Ledgers>();
            using (var context = new CloudDBContext())
            {
                ledgers = await context.Ledgers.ToListAsync();
            }
            return ledgers;
        }

        // GET api/<LedgersApiController>/5
        [HttpGet("{id}")]
        public async Task<Ledgers> Get(int id)
        {
            Ledgers ledgers = new Ledgers();
            using (var context = new CloudDBContext())
            {
                ledgers = context.Ledgers.Where(s => s.Id == id).FirstOrDefault<Ledgers>();
            }
            return ledgers; 
        }

        // POST api/<LedgersApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(Ledgers Ledger)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _Ledger = new Ledgers();

                    _Ledger.AccountCode = Ledger.AccountCode; 
                    _Ledger.AccountName = Ledger.AccountName; 
                    _Ledger.AccountType = Ledger.AccountType;
                    _Ledger.Currency = Ledger.Currency;
                    _Ledger.Allowcostcentre = Ledger.Allowcostcentre;
                    _Ledger.EnableCheckprinting = Ledger.EnableCheckprinting;
                    _Ledger.IsVATReturns = Ledger.IsVATReturns;
                    _Ledger.AccountNumber = Ledger.AccountNumber;
                    _Ledger.monthlybudget = Ledger.monthlybudget;
                    _Ledger.Tin = Ledger.Tin;
                    _Ledger.VatNumber = Ledger.VatNumber;
                    _Ledger.IsComposition = Ledger.IsComposition;
                    _Ledger.Aadharnumber = Ledger.Aadharnumber;
                    _Ledger.Address = Ledger.Address;
                    _Ledger.Addressline2 = Ledger.Addressline2;
                    _Ledger.Addressline3 = Ledger.Addressline3;

                    _Ledger.Location = Ledger.Location;
                    _Ledger.State = Ledger.State;
                    _Ledger.Country = Ledger.Country;
                    _Ledger.Postalcode = Ledger.Postalcode;
                    _Ledger.Telnumber = Ledger.Telnumber;
                    _Ledger.Faxnumber = Ledger.Faxnumber;
                    _Ledger.Emailid = Ledger.Emailid;
                    _Ledger.Website = Ledger.Website;

                    _Ledger.UploadImageName = Ledger.UploadImageName;
                    _Ledger.creditlimit = Ledger.creditlimit;
                    _Ledger.payterms = Ledger.payterms;
                    _Ledger.Defaultdiscount = Ledger.Defaultdiscount;
                    //_Ledger.Pricelevel = Ledger.Pricelevel;

                    _Ledger.ContactpersonName = Ledger.ContactpersonName;
                    _Ledger.Designation = Ledger.Designation;
                    _Ledger.ConperTelnumber = Ledger.ConperTelnumber;
                    _Ledger.MobileNo = Ledger.MobileNo;
                    _Ledger.ConperEmailId = Ledger.ConperEmailId;

                    context.Ledgers.Add(_Ledger);
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
                Message = "Ledger Added Successfully!"
            };

        }

        // PUT api/<LedgersApiController>/5 
        public async Task<UserCreateResponseRP> Put(Ledgers Ledger)
        {
            using (var context = new CloudDBContext())
            {
                Ledgers _Ledger = context.Ledgers.FirstOrDefault(item => item.Id == Ledger.Id);

                // Validate entity is not null 
                if (_Ledger != null)
                {
                    _Ledger.AccountCode = Ledger.AccountCode;
                    _Ledger.AccountName = Ledger.AccountName;
                    _Ledger.AccountType = Ledger.AccountType;
                    _Ledger.Currency = Ledger.Currency;
                    _Ledger.Allowcostcentre = Ledger.Allowcostcentre;
                    _Ledger.EnableCheckprinting = Ledger.EnableCheckprinting;
                    _Ledger.IsVATReturns = Ledger.IsVATReturns;
                    _Ledger.Tin = Ledger.Tin;
                    _Ledger.VatNumber = Ledger.VatNumber;
                    _Ledger.IsComposition = Ledger.IsComposition;
                    _Ledger.Aadharnumber = Ledger.Aadharnumber;
                    _Ledger.Address = Ledger.Address;
                    _Ledger.Addressline2 = Ledger.Addressline2;
                    _Ledger.Addressline3 = Ledger.Addressline3;

                    _Ledger.Location = Ledger.Location;
                    _Ledger.State = Ledger.State;
                    _Ledger.Country = Ledger.Country;
                    _Ledger.Postalcode = Ledger.Postalcode;
                    _Ledger.Telnumber = Ledger.Telnumber;
                    _Ledger.Faxnumber = Ledger.Faxnumber;
                    _Ledger.Emailid = Ledger.Emailid;
                    _Ledger.Website = Ledger.Website;

                    _Ledger.UploadImageName = Ledger.UploadImageName;
                    _Ledger.creditlimit = Ledger.creditlimit;
                    _Ledger.payterms = Ledger.payterms;
                    _Ledger.Defaultdiscount = Ledger.Defaultdiscount;
                    //_Ledger.Pricelevel = Ledger.Pricelevel;
                    //_Ledger.monthlybudget = Ledger.monthlybudget;

                    _Ledger.ContactpersonName = Ledger.ContactpersonName;
                    _Ledger.Designation = Ledger.Designation;
                    _Ledger.ConperTelnumber = Ledger.ConperTelnumber;
                    _Ledger.MobileNo = Ledger.MobileNo;
                    _Ledger.ConperEmailId = Ledger.ConperEmailId;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Ledger updated Successfully!"
            };
        }


        // DELETE api/<LedgersApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Ledgers.Where(s => s.Id == id).FirstOrDefault<Ledgers>();
                    if (doc != null)
                    {
                        context.Ledgers.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Ledger Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Ledger");
            }
        }


    }
}
