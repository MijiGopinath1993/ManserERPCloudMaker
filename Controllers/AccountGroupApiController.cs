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
    public class AccountGroupApiController : ControllerBase
    {
        // GET: api/<AccountGroupApiController>
        [HttpGet]
        public async Task<List<AccountGroup>> Get()
        {
            using (var context = new CloudDBContext())
            {
                var accountGroups = await (from accgrp in context.Accountgroup
                                           select new AccountGroup
                                           {
                                               Id = accgrp.Id,
                                               Accountgroup = accgrp.Accountgroup,
                                               Undergroup = accgrp.Undergroup,
                                               GroupType = accgrp.GroupType,

                                           }).ToListAsync();

                return accountGroups;
            }
        }

        // GET api/<AccountGroupApiController>/5
        [HttpGet("{id}")]
        public async Task<AccountGroup> Get(int id)
        {
            AccountGroup accountGroups = new AccountGroup();
            using (var context = new CloudDBContext())
            {
                accountGroups = context.Accountgroup.Where(s => s.Id == id).FirstOrDefault<AccountGroup>();
            }
            return accountGroups;
        }

        // POST api/<AccountGroupApiController>
        [HttpPost]
        public async Task<UserCreateResponseRP> Post(AccountGroup accountgroup)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var _accountgroup  = new AccountGroup();

                    _accountgroup.Accountgroup = accountgroup.Accountgroup;
                    _accountgroup.Undergroup = accountgroup.Undergroup;
                    _accountgroup.GroupType = accountgroup.GroupType;
                    _accountgroup.CreatedOn = DateTime.Today;

                    context.Accountgroup.Add(_accountgroup);
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
                Message = "Account Group Added Successfully!"
            };

        }

        // PUT api/<AccountGroupApiController>/5
      
        public async Task<UserCreateResponseRP> Put(AccountGroup accountgroup)
        {
            using (var context = new CloudDBContext())
            {
                AccountGroup _accountgroup = context.Accountgroup.FirstOrDefault(item => item.Id == accountgroup.Id);

                // Validate entity is not null
                if (_accountgroup != null)
                {

                    _accountgroup.Accountgroup = accountgroup.Accountgroup;
                    _accountgroup.Undergroup = accountgroup.Undergroup;
                    _accountgroup.GroupType = accountgroup.GroupType;
                    _accountgroup.CreatedOn = DateTime.Today;

                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Account Group updated Successfully!"
            };
        }

        // DELETE api/<AccountGroupApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
               using (var context = new CloudDBContext())
                {
                    var doc = context.Accountgroup.Where(s => s.Id == id).FirstOrDefault<AccountGroup>();
                    if (doc != null)
                    {
                        context.Accountgroup.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "Account Group Deleted Successfully!"
                };
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Account Group");
            }
        }
 
        [HttpDelete]
        public async Task<IActionResult> DeleteAccountGroup([FromBody] DeleteRequest request)
        {
            if (request?.Ids == null || !request.Ids.Any())
            {
                return BadRequest(new { success = false, message = "No IDs provided for deletion." });
            }
            try
            {
                using (var context = new CloudDBContext())
                {
                    var accgrpToDelete = await context.Accountgroup
                    .Where(employee => request.Ids.Contains(employee.Id))
                    .ToListAsync();

                    if (accgrpToDelete.Any())
                    {
                        context.Accountgroup.RemoveRange(accgrpToDelete);
                        await context.SaveChangesAsync();
                        return Ok(new { success = true, message = "Account group successfully deleted." });
                    }
                    else
                    {
                        return NotFound(new { success = false, message = "No matching  found." });
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
