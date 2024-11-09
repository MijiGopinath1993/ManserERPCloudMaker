using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierApiController : ControllerBase
    {
        // GET: api/<SupplierApiController>
        [HttpGet]
        public async Task<List<Suppliers>> Get()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            using (var context = new CloudDBContext())
            {
                suppliers = await context.Suppliers.ToListAsync();
            }
            return suppliers;
        }

        // GET api/<SupplierApiController>/5
        [HttpGet("{id}")]
        public async Task<Suppliers> Get(int id)
        {
            Suppliers supplier = new Suppliers();
            using (var context = new CloudDBContext())
            {
                supplier = context.Suppliers.Where(s => s.Id == id).FirstOrDefault<Suppliers>();
            }
            return supplier;
        }

        // POST api/<SupplierApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(Suppliers supplier)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _supplier = new Suppliers();

                    _supplier.SupplierCode = supplier.SupplierCode;
                    _supplier.SupplierName = supplier.SupplierName;
                    _supplier.SupplierGroup = supplier.SupplierGroup;
                    _supplier.AccountType = supplier.AccountType;
                    _supplier.Currency = supplier.Currency;
                    _supplier.Allowcostcentre = supplier.Allowcostcentre;
                    _supplier.Tin = supplier.Tin;
                    _supplier.VatNumber = supplier.VatNumber;
                    _supplier.Aadharnumber = supplier.Aadharnumber;
                    _supplier.BillingNoORAddress = supplier.BillingNoORAddress;
                    _supplier.addressline2 = supplier.addressline2;
                    _supplier.addressline3 = supplier.addressline3;

                    _supplier.Location = supplier.Location;
                    _supplier.State = supplier.State;
                    _supplier.Country = supplier.Country;
                    _supplier.Postalcode = supplier.Postalcode;
                    _supplier.Telnumber = supplier.Telnumber;
                    _supplier.Faxnumber = supplier.Faxnumber;
                    _supplier.Emailid = supplier.Emailid;
                    _supplier.Website = supplier.Website;
                     
                    _supplier.UploadImageName = supplier.UploadImageName;
                    _supplier.creditlimit = supplier.creditlimit;
                    _supplier.payterms = supplier.payterms;
                    _supplier.Defaultdiscount = supplier.Defaultdiscount;
                    _supplier.Pricelevel = supplier.Pricelevel;
                    _supplier.monthlybudget = supplier.monthlybudget;
                     
                    _supplier.ContactpersonName = supplier.ContactpersonName;
                    _supplier.Designation = supplier.Designation;
                    _supplier.ConperTelnumber = supplier.ConperTelnumber;
                    _supplier.MobileNo = supplier.MobileNo;
                    _supplier.ConperEmailId = supplier.ConperEmailId;

                    context.Suppliers.Add(_supplier);
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
                Message = "Supplier Added Successfully!"
            };

        }

        // PUT api/<SupplierApiController>/5 
        public async Task<UserCreateResponseRP> Put(Suppliers supplier)
        {
            using (var context = new CloudDBContext())
            {
                Suppliers _supplier  = context.Suppliers.FirstOrDefault(item => item.Id == supplier.Id);
                 
                // Validate entity is not null 
                if (_supplier != null)
                {
                    _supplier.SupplierName = supplier.SupplierName;
                    _supplier.SupplierGroup = supplier.SupplierGroup;
                    _supplier.AccountType = supplier.AccountType;
                    _supplier.Currency = supplier.Currency;
                    _supplier.Allowcostcentre = supplier.Allowcostcentre;
                    _supplier.Tin = supplier.Tin;
                    _supplier.VatNumber = supplier.VatNumber;
                    _supplier.Aadharnumber = supplier.Aadharnumber;
                    _supplier.BillingNoORAddress = supplier.BillingNoORAddress;
                    _supplier.addressline2 = supplier.addressline2;
                    _supplier.addressline3 = supplier.addressline3;

                    _supplier.Location = supplier.Location;
                    _supplier.State = supplier.State;
                    _supplier.Country = supplier.Country;
                    _supplier.Postalcode = supplier.Postalcode;
                    _supplier.Telnumber = supplier.Telnumber;
                    _supplier.Faxnumber = supplier.Faxnumber;
                    _supplier.Emailid = supplier.Emailid;
                    _supplier.Website = supplier.Website;

                    _supplier.UploadImageName = supplier.UploadImageName;
                    _supplier.creditlimit = supplier.creditlimit;
                    _supplier.payterms = supplier.payterms;
                    _supplier.Defaultdiscount = supplier.Defaultdiscount;
                    _supplier.Pricelevel = supplier.Pricelevel;
                    _supplier.monthlybudget = supplier.monthlybudget;

                    _supplier.ContactpersonName = supplier.ContactpersonName;
                    _supplier.Designation = supplier.Designation;
                    _supplier.ConperTelnumber = supplier.ConperTelnumber;
                    _supplier.MobileNo = supplier.MobileNo;
                    _supplier.ConperEmailId = supplier.ConperEmailId;

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

        // DELETE api/<SupplierApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Suppliers.Where(s => s.Id == id).FirstOrDefault<Suppliers>();
                    if (doc != null)
                    {
                        context.Suppliers.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Supplier Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Supplier");
            }
        }
    }
}
