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
    public class ProductCategoryApiController : ControllerBase
    {
        // GET: api/<ProductCategoryApiController>
        //[HttpGet]
        //public async Task<List<ProductCategory>> Get() 
        //{
        //    List<ProductCategory> productcategory = new List<ProductCategory>();
        //    using (var context = new CloudDBContext())
        //    {
        //        productcategory = await context.Productcategory.ToListAsync();
        //    }
        //    return productcategory; 
        //}

        // GET api/<ProductCategoryApiController>/5
        [HttpGet("{id}")]
        public async Task<ProductCategory> Get(int id)
        {
            ProductCategory productcategory = new ProductCategory();
            using (var context = new CloudDBContext())
            {
                productcategory = context.Productcategory.Where(s => s.Id == id).FirstOrDefault<ProductCategory>();
            }
            return productcategory;
        }

        // POST api/<ProductCategoryApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(ProductCategory productcategory)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _productcategory = new ProductCategory();

                    _productcategory.CategoryName = productcategory.CategoryName;
                    _productcategory.UnderGroup = productcategory.UnderGroup;
                    _productcategory.CreatedOn = DateTime.Today;

                    context.Productcategory.Add(_productcategory);
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
                Message = "Product Category Added Successfully!"
            };

        }

        // PUT api/<ProductCategoryApiController>/5 
        public async Task<UserCreateResponseRP> Put(ProductCategory productcategory)
        {
            using (var context = new CloudDBContext())
            {
                ProductCategory _productcategory  = context.Productcategory.FirstOrDefault(item => item.Id == productcategory.Id);

                // Validate entity is not null
                if (_productcategory != null)
                {
                    _productcategory.CategoryName = productcategory.CategoryName;
                    _productcategory.UnderGroup = productcategory.UnderGroup;
                    _productcategory.CreatedOn = DateTime.Today;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Product Category updated Successfully!"
            };
        }

        // DELETE api/<ProductCategoryApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Productcategory.Where(s => s.Id == id).FirstOrDefault<ProductCategory>();
                    if (doc != null)
                    {
                        context.Productcategory.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Product Category Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Product Category");
            }
        }




        //Modified By-Akshara
        //To get  details to grid
        //To delete multiple items from grid
        [HttpGet]
        public async Task<List<ProductCategory>> Get()
        {          
            using (var context = new CloudDBContext())
            {
                var productcategory = await (from procatg in context.Productcategory
                                             select new ProductCategory
                                             {
                                                  Id = procatg.Id,
                                                  CategoryName = procatg.CategoryName,
                                                  UnderGroup = procatg.UnderGroup,                                           
                                                  CreatedOn = procatg.CreatedOn,                                           
                                             }).ToListAsync();

                return productcategory;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductCategory([FromBody] DeleteRequest request)
        {
            if (request?.Ids == null || !request.Ids.Any())
            {
                return BadRequest(new { success = false, message = "No IDs provided for deletion." });
            }
            try
            {
                using (var context = new CloudDBContext())
                {
                    var catgToDelete = await context.Productcategory
                    .Where(catgory => request.Ids.Contains(catgory.Id))
                    .ToListAsync();

                    if (catgToDelete.Any())
                    {
                        context.Productcategory.RemoveRange(catgToDelete);
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
