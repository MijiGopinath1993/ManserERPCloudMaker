using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressApiController : ControllerBase
    {
        // GET: api/<CustomerAddressApiController>
        [HttpGet]
        public async Task<List<CustomerAddress>> Get()
        {
            using (var context = new CloudDBContext())
            {
                var customerAddress = await (from custAdrs in context.Customeraddress
                                             select new CustomerAddress
                                             {
                                                Id = custAdrs.Id,
                                                CustomerId = custAdrs.CustomerId,
                                                Code =  custAdrs.Code,
                                                Name = custAdrs.Name,
                                                NameAr = custAdrs.NameAr,
                                                ShortAddress = custAdrs.ShortAddress,
                                                BuildingNo = custAdrs.BuildingNo,
                                                StreetName = custAdrs.StreetName,
                                                SecondaryNo = custAdrs.SecondaryNo,
                                                City = custAdrs.City,
                                                District = custAdrs.District,
                                                State = custAdrs.State,
                                                PostalCode = custAdrs.PostalCode,
                                                Country = custAdrs.Country,
                                                TelNo = custAdrs.TelNo

                                             }).ToListAsync();

                return customerAddress;
            }
        }

        // GET api/<CustomerAddressApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerAddressApiController>
        [HttpPost] 
        public async Task<UserCreateResponseRP> Post(CustomerAddress customerAddress)
        {
            try
            {
                var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUser"));

                using (var context = new CloudDBContext())
                {
                    var _customerAddress  = new CustomerAddress();

                    _customerAddress.CustomerId = customerAddress.CustomerId;
                    _customerAddress.Code = customerAddress.Code;
                    _customerAddress.Name = customerAddress.Name;
                    _customerAddress.NameAr = customerAddress.NameAr;
                    _customerAddress.ShortAddress = customerAddress.ShortAddress;
                    _customerAddress.BuildingNo = customerAddress.BuildingNo;
                    _customerAddress.StreetName = customerAddress.StreetName;
                    _customerAddress.SecondaryNo = customerAddress.SecondaryNo;
                    _customerAddress.City = customerAddress.City;
                    _customerAddress.District = customerAddress.District;
                    _customerAddress.State = customerAddress.State;
                    _customerAddress.PostalCode = customerAddress.PostalCode;
                    _customerAddress.Country = customerAddress.Country;
                    _customerAddress.TelNo = customerAddress.TelNo;

                    context.Customeraddress.Add(_customerAddress);
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
                Message = "Address Added Successfully!"
            };

        }

        // PUT api/<CustomerAddressApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerAddressApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
