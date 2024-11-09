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
    public class ProductGroupsApiController : ControllerBase
    {
        // GET: api/<ProductGroupApiController>
        //[HttpGet]
        //public async Task<List<ProductGroups>> Get()
        //{
        //    List<ProductGroups> productgroups = new List<ProductGroups>();
        //    using (var context = new CloudDBContext())
        //    {
        //        productgroups = await context.Productgroups.ToListAsync();
        //    }
        //    return productgroups;
        //}

        // GET api/<ProductGroupApiController>/5
        [HttpGet("{id}")]
        public async Task<ProductGroups> Get(int id)
        {
            ProductGroups productgroups = new ProductGroups();
            using (var context = new CloudDBContext())
            {
                productgroups = context.Productgroups.Where(s => s.Id == id).FirstOrDefault<ProductGroups>();
            }
            return productgroups;
        }

        // POST api/<ProductGroupApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(ProductGroups productgroups)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _productgroups  = new ProductGroups();

                   _productgroups.GroupName = productgroups.GroupName;
                   _productgroups.UnderGroup = productgroups.UnderGroup;
                   _productgroups.UnitName = productgroups.UnitName;
                   _productgroups.TotalQuantity = productgroups.TotalQuantity;
                   _productgroups.OrderNumber = productgroups.OrderNumber;
                    _productgroups.CreatedOn = DateTime.Today;

                    context.Productgroups.Add(_productgroups);
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
                Message = "Product Group Added Successfully!"
            };

        }

        // PUT api/<ProductGroupApiController>/5 
        public async Task<UserCreateResponseRP> Put(ProductGroups productgroups)
        {
            using (var context = new CloudDBContext())
            {
                ProductGroups _productgroups = context.Productgroups.FirstOrDefault(item => item.Id == productgroups.Id);
                 
                // Validate entity is not null
                if (_productgroups != null)
                {
                    _productgroups.GroupName = productgroups.GroupName;
                    _productgroups.UnderGroup = productgroups.UnderGroup;
                    _productgroups.UnitName = productgroups.UnitName;
                    _productgroups.TotalQuantity = productgroups.TotalQuantity;
                    _productgroups.OrderNumber = productgroups.OrderNumber;
                    _productgroups.CreatedOn = DateTime.Today;
                     
                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Product Group updated Successfully!"
            };
        }

        // DELETE api/<ProductGroupApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Productgroups.Where(s => s.Id == id).FirstOrDefault<ProductGroups>();
                    if (doc != null)
                    {
                        context.Productgroups.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Product Group Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Product Group");
            }
        }


        //[HttpGet]
        //public async Task<List<ProductGroups>> Get()
        //{
        //    List<ProductGroups> productgroups = new List<ProductGroups>();
        //    using (var context = new CloudDBContext())
        //    {
        //        productgroups = await context.Productgroups.ToListAsync();
        //    }
        //    return productgroups;
        //}



        //Modified By-Akshara
        //To get  details to grid
        //To delete multiple items from grid
        [HttpGet]
        public async Task<List<ProductGroups>> Get()
        {
            using (var context = new CloudDBContext())
            {
                var productgroups = await (from procatg in context.Productgroups
                                             select new ProductGroups
                                             {
                                                 Id = procatg.Id,
                                                 GroupName = procatg.GroupName,
                                                 UnderGroup = procatg.UnderGroup,
                                                 UnitName = procatg.UnitName,
                                                 TotalQuantity = procatg.TotalQuantity,
                                                 OrderNumber = procatg.OrderNumber,
                                                 CreatedOn = procatg.CreatedOn,
                                             }).ToListAsync();

                return productgroups;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductgrps([FromBody] DeleteRequest request)
        {
            if (request?.Ids == null || !request.Ids.Any())
            {
                return BadRequest(new { success = false, message = "No IDs provided for deletion." });
            }
            try
            {
                using (var context = new CloudDBContext())
                {
                    var grpToDelete = await context.Productgroups
                    .Where(grp => request.Ids.Contains(grp.Id))
                    .ToListAsync();

                    if (grpToDelete.Any())
                    {
                        context.Productgroups.RemoveRange(grpToDelete);
                        await context.SaveChangesAsync();
                        return Ok(new { success = true, message = "Category successfully deleted." });
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
