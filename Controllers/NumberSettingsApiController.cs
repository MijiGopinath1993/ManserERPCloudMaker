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
    public class NumberSettingsApiController : ControllerBase
    {
        // GET: api/<NumberSettingsApiController>
        [HttpGet]
        public async Task<List<InvoiceNumberSettings>> Get()
        {
            List<InvoiceNumberSettings> invoiceNumberSettings = new List<InvoiceNumberSettings>();
            using (var context = new CloudDBContext())
            {
                invoiceNumberSettings = await context.Invoicenumbersettings.ToListAsync();
            }
            return invoiceNumberSettings; 
        }
            // GET api/<NumberSettingsApiController>/5
            [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NumberSettingsApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(InvoiceNumberSettings invoiceNumberSettings)
        {
            try 
            {
                using (var context = new CloudDBContext()) 
                {  
                    var _invoiceNumSettings = new InvoiceNumberSettings();  

                    _invoiceNumSettings.Branch = invoiceNumberSettings.Branch;
                    _invoiceNumSettings.VoucherName = invoiceNumberSettings.VoucherName;
                    _invoiceNumSettings.printaftersave = invoiceNumberSettings.printaftersave;
                    _invoiceNumSettings.printbarcodeaftersave = invoiceNumberSettings.printbarcodeaftersave;
                    _invoiceNumSettings.Invnumberingmethod = invoiceNumberSettings.Invnumberingmethod;
                    _invoiceNumSettings.Allowduplicateinvno = invoiceNumberSettings.Allowduplicateinvno;
                     
                    _invoiceNumSettings.Invnumberstart = invoiceNumberSettings.Invnumberstart;
                    _invoiceNumSettings.MaxNoofdigits = invoiceNumberSettings.MaxNoofdigits;
                    _invoiceNumSettings.Invoiceprefix = invoiceNumberSettings.Invoiceprefix;
                    _invoiceNumSettings.Invoicepostfix = invoiceNumberSettings.Invoicepostfix; 
                     
                    context.Invoicenumbersettings.Add(_invoiceNumSettings);
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
                Message = "Settings Added Successfully!"
            };


        }

        // PUT api/<NumberSettingsApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NumberSettingsApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
