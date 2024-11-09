using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyApiController : ControllerBase
    {
        // GET: api/<CompanyApiController>
        [HttpGet]
        public async Task<List<Company>> Get()
        {
            List<Company> lstCompanydetails = new List<Company>();
            //var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUserID"));
            using (var context = new CloudDBContext())
            {
                lstCompanydetails = await context.Company.ToListAsync();
            }
            return lstCompanydetails; 
        }

        // GET api/<CompanyApiController>/5
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {

            Company Companydetails = new Company(); 
            using (var context = new CloudDBContext())
            {
                Companydetails = await context.Company.Where(s => s.Id == id).FirstOrDefaultAsync();
            }
            return Companydetails;

        }

        // POST api/<CompanyApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(Company company) 
        {
            try
            {
                using (var context = new CloudDBContext()) 
                {
                    var existingUser = await context.Company.Where(x => x.Companyname == company.Companyname).FirstOrDefaultAsync();
                    if (existingUser != null)
                    {
                        var _response  = new UserCreateResponseRP
                        {
                            Status = false,
                            UserID = -1,
                            Message = existingUser.Companyname == company.Companyname ? "Company Name already exists." : ""
                        };
                        return _response;
                    }
                      
                    var _company = new Company();
                    _company.Companyname    = company.Companyname; 
                    _company.MailingName    = company.MailingName;
                    _company.LicenseNo = company.LicenseNo;  
                    _company.GSTNo = company.GSTNo;
                    _company.VATNo = company.VATNo;
                    _company.Address1 = company.Address1;
                    _company.Address2 = company.Address2;
                    _company.State = company.State;
                    _company.Country = company.Country;
                    _company.Pincode = company.Pincode ;
                    _company.TelNo = company.TelNo;
                    _company.FaxNo = company.FaxNo;
                    _company.Emailid = company.Emailid;
                    _company.BaseCurrency = company.BaseCurrency;
                    _company.Currencysymbol = company.Currencysymbol;
                    _company.Decimalsymbol = company.Decimalsymbol;
                    _company.DecialPlace = company.DecialPlace;

                    _company.CompBankname = company.CompBankname;
                    _company.CompAccNo = company.CompAccNo;
                    _company.CompBranch = company.CompBranch;

                    _company.LogoImageFile = company.LogoImageFile;
                    _company.DateFormat = company.DateFormat;
                    _company.Accperiodfrom = company.Accperiodfrom;
                    _company.Accperiodto = company.Accperiodto;
                    _company.BookPeriodfrom = company.BookPeriodfrom;
                    _company.BookPeriodto = company.BookPeriodto;

                    _company.AdminUsername = company.AdminUsername;
                    _company.Adminpassword = company.Adminpassword;
                    _company.Confpassword = company.Confpassword;
                    _company.AdminEmailId = company.AdminEmailId;
                    _company.Imagefolderpath = company.Imagefolderpath;

                    context.Company.Add(_company);
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
                Message = "Company Created Successfully!"
            };

        }

        // PUT api/<CompanyApiController>/5 
        public async Task<UserCreateResponseRP> Put(Company company) 
        {
            using (var context = new CloudDBContext())
            {
                Company _company = context.Company.FirstOrDefault(item => item.Id == company.Id);

                // Validate entity is not null
                if (_company != null)
                {

                    _company.Companyname = company.Companyname;
                    _company.MailingName = company.MailingName;
                    _company.LicenseNo = company.LicenseNo;
                    _company.GSTNo = company.GSTNo;
                    _company.VATNo = company.VATNo;
                    _company.Address1 = company.Address1;
                    _company.Address2 = company.Address2;
                    _company.State = company.State;
                    _company.Country = company.Country;
                    _company.Pincode = company.Pincode;
                    _company.TelNo = company.TelNo;
                    _company.FaxNo = company.FaxNo;
                    _company.Emailid = company.Emailid;
                    _company.BaseCurrency = company.BaseCurrency;
                    _company.Currencysymbol = company.Currencysymbol;
                    _company.Decimalsymbol = company.Decimalsymbol;
                    _company.DecialPlace = company.DecialPlace;

                    _company.CompBankname = company.CompBankname;
                    _company.CompAccNo = company.CompAccNo;
                    _company.CompBranch = company.CompBranch;

                    _company.LogoImageFile = company.LogoImageFile;
                    _company.DateFormat = company.DateFormat;
                    _company.Accperiodfrom = company.Accperiodfrom;
                    _company.Accperiodto = company.Accperiodto;
                    _company.BookPeriodfrom = company.BookPeriodfrom;
                    _company.BookPeriodto = company.BookPeriodto;

                    _company.AdminUsername = company.AdminUsername;
                    _company.Adminpassword = company.Adminpassword;
                    _company.Confpassword = company.Confpassword;
                    _company.AdminEmailId = company.AdminEmailId;
                    _company.Imagefolderpath = company.Imagefolderpath;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Company updated Successfully!"
            };
        }

        // DELETE api/<CompanyApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
