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
    public class ProductUnitsApiController : ControllerBase
    {
        // GET: api/<ProductUnitsApiController>
        //[HttpGet]
        //public async Task<List<ProductUnits>> Get()
        //{
        //    List<ProductUnits> productUnits = new List<ProductUnits>();
        //    using (var context = new CloudDBContext())
        //    {
        //        productUnits = await context.Productunits.ToListAsync();
        //    }
        //    return productUnits;
        //}

        // GET api/<ProductUnitsApiController>/5
        [HttpGet("{id}")]
        public async Task<ProductUnits> Get(int id)
        {
            ProductUnits productUnits = new ProductUnits();
            using (var context = new CloudDBContext())
            {
                productUnits = context.Productunits.Where(s => s.Id == id).FirstOrDefault<ProductUnits>();
            }
            return productUnits;
        }

        // POST api/<ProductUnitsApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(ProductUnits productUnits)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _productUnits = new ProductUnits();

                    _productUnits.UnitName = productUnits.UnitName;
                    _productUnits.GSTRUnit = productUnits.GSTRUnit;
                    _productUnits.UnitType = productUnits.UnitType;
                    _productUnits.FormalName = productUnits.FormalName;
                    _productUnits.CreatedOn = DateTime.Today;
                    _productUnits.Decimals = productUnits.Decimals;

                    context.Productunits.Add(_productUnits);
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
                Message = "Product Unit Added Successfully!"
            };

        }

        // PUT api/<ProductUnitsApiController>/5 
        public async Task<UserCreateResponseRP> Put(ProductUnits productUnits)
        {
            using (var context = new CloudDBContext())
            {
                ProductUnits _productUnits = context.Productunits.FirstOrDefault(item => item.Id == productUnits.Id);

                // Validate entity is not null
                if (_productUnits != null)
                {

                    _productUnits.UnitName = productUnits.UnitName;
                    _productUnits.GSTRUnit = productUnits.GSTRUnit;
                    _productUnits.UnitType = productUnits.UnitType;
                    _productUnits.FormalName = productUnits.FormalName;
                    _productUnits.CreatedOn = DateTime.Today;
                    _productUnits.Decimals = productUnits.Decimals;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Product Unit updated Successfully!"
            };
        }

        // DELETE api/<ProductUnitsApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Productunits.Where(s => s.Id == id).FirstOrDefault<ProductUnits>();
                    if (doc != null)
                    { 
                        context.Productunits.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Product Unit Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Product Unit");
            }
        }


        //Modified By-Akshara
        //To get Employe details to grid
        //To delete multiple items from grid
        [HttpGet]
        public async Task<List<ProductUnits>> Get()
        {           
            using (var context = new CloudDBContext())
            {
                var productUnits = await (from prounits in context.Productunits
                                           select new ProductUnits
                                           {
                                               Id = prounits.Id,
                                               UnitName = prounits.UnitName,
                                               GSTRUnit = prounits.GSTRUnit,
                                               UnitType = prounits.UnitType,
                                               FormalName = prounits.FormalName,
                                               CreatedOn = prounits.CreatedOn,                                              
                                           }).ToListAsync();

                return productUnits;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUnits([FromBody] DeleteRequest request)
        {
            if (request?.Ids == null || !request.Ids.Any())
            {
                return BadRequest(new { success = false, message = "No IDs provided for deletion." });
            }
            try
            {
                using (var context = new CloudDBContext())
                {
                    var unitsToDelete = await context.Productunits
                    .Where(punits => request.Ids.Contains(punits.Id))
                    .ToListAsync();

                    if (unitsToDelete.Any())
                    {
                        context.Productunits.RemoveRange(unitsToDelete);
                        await context.SaveChangesAsync();
                        return Ok(new { success = true, message = "Units successfully deleted." });
                    }
                    else
                    {
                        return NotFound(new { success = false, message = "No matching found." });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "An error occurred.", details = ex.Message });
            }
        }


    }
}
