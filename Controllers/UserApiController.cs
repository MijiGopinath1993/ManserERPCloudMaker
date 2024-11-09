using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        // GET: api/<UserApiController>
        [HttpGet]
        public async Task<List<Users>> Get() 
        {
            List<Users> lstUserdetails = new List<Users>();
            //var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUserID"));
           
            using (var context = new CloudDBContext()) 
            {
                var list = from user in context.Users
                             join perm in context.Permisions 
                             on user.UserDepartment equals perm.Pagecode
                            //where perm.Permisionpages == null || perm.Permisionpages != null
                           select new Users
                             {
                                 Id = user.Id,
                                 UserName = user.UserName,
                                 UserId = user.UserId,
                                 UserDepartment = perm.Permisionpages,
                                 UserType = user.UserType,
                                 UserEmailId = user.UserEmailId,
                                 IsActive = user.IsActive,
                             };
                lstUserdetails = await list.ToListAsync();
            }


            return lstUserdetails;
        }

        // GET api/<UserApiController>/5
        [HttpGet("{id}")]
        public async Task<Users> Get(int id)
        {
            try
            {
                Users users = new Users();
                using (var context = new CloudDBContext())
                {
                    users = await context.Users.Where(s => s.Id == id).FirstOrDefaultAsync<Users>();
                }
                return users;
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        // POST api/<UserApiController>
        [HttpPost] 
        public async Task<UserCreateResponseRP> Post(Users users) 
        {             
            try
            { 
                using (var context = new CloudDBContext())
                {
                    var existingUser = await context.Users.Where(x => x.UserId == users.UserId).FirstOrDefaultAsync();
                    if (existingUser != null)
                    {
                        var _response = new UserCreateResponseRP
                        {
                            Status = false,
                            UserID = -1,
                            Message = existingUser.UserId == users.UserId ? "User ID already exists." : ""
                        };
                        return _response;
                    }

                    byte[] hashedPassword = HashPassword(users.UserPasswordHash);

                    var _users = new Users();
                    _users.UserName = users.UserName;
                    _users.UserPassword = hashedPassword;
                    _users.UserType = users.UserType;
                    _users.UserEmailId = users.UserEmailId;
                    _users.UserId = users.UserId;
                    _users.UserSecurityQ1 = users.UserSecurityQ1;
                    _users.UserSecurityQ2 = users.UserSecurityQ2;
                    _users.UserSecurityA1 = users.UserSecurityA1;
                    _users.UserSecurityA2 = users.UserSecurityA2;
                    _users.UserDepartment = users.UserDepartment;
                    _users.StoreName = users.LocationName;
                    _users.LocationName = users.LocationName;
                    _users.IsActive = users.IsActive;
                    _users.IsLogin = users.IsLogin;
                    _users.SQLUserID = users.SQLUserID;
                    _users.SQLpwd = hashedPassword;
                    _users.CounterID = users.CounterID;

                    context.Users.Add(_users);
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
                Message = "User Created Successfully!"
            };
            
        }
        public byte[] HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return hashedPassword;

        }
         
        // PUT api/<UserApiController>/5 
        public async Task<ActionResult<UserCreateResponseRP>> Put(Users users)
        { 
            try
            {
                using (var context = new CloudDBContext())
                {  
                    byte[] hashedPassword = HashPassword(users.UserPasswordHash);

                    Users _users = context.Users.FirstOrDefault(item => item.Id == users.Id); 

                    bool res = unhashAndValidatePassword(users.UserPasswordHash, Convert.ToString(_users.UserPasswordHash));
                    
                    if(res) {
                        if (_users != null)
                        {
                            _users.UserName = users.UserName;
                            _users.UserPassword = hashedPassword;
                            _users.UserType = users.UserType;
                            _users.UserEmailId = users.UserEmailId;
                            _users.UserId = users.UserId;
                            _users.UserSecurityQ1 = users.UserSecurityQ1;
                            _users.UserSecurityQ2 = users.UserSecurityQ2;
                            _users.UserSecurityA1 = users.UserSecurityA1;
                            _users.UserSecurityA2 = users.UserSecurityA2;
                            _users.UserDepartment = users.UserDepartment;
                            _users.StoreName = users.LocationName;
                            _users.LocationName = users.LocationName;
                            _users.IsActive = users.IsActive;
                            _users.IsLogin = users.IsLogin;
                            _users.SQLUserID = users.SQLUserID;
                            _users.SQLpwd = hashedPassword;
                            _users.CounterID = users.CounterID;

                            // Save changes in database
                            var result = context.SaveChanges();
                        }
                    }
                    else
                    {
                        if (_users != null)
                        {
                            _users.UserName = users.UserName; 
                            _users.UserType = users.UserType;
                            _users.UserEmailId = users.UserEmailId;
                            _users.UserId = users.UserId;
                            _users.UserSecurityQ1 = users.UserSecurityQ1;
                            _users.UserSecurityQ2 = users.UserSecurityQ2;
                            _users.UserSecurityA1 = users.UserSecurityA1;
                            _users.UserSecurityA2 = users.UserSecurityA2;
                            _users.UserDepartment = users.UserDepartment;
                            _users.StoreName = users.LocationName;
                            _users.LocationName = users.LocationName;
                            _users.IsActive = users.IsActive;
                            _users.IsLogin = users.IsLogin;
                            _users.SQLUserID = users.SQLUserID; 
                            _users.CounterID = users.CounterID;

                            // Save changes in database
                            var result = context.SaveChanges();
                        }
                    }

                    // Validate entity is not null


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
                Message = "User Updated Successfully!"
            };
        }
        private bool unhashAndValidatePassword(string enteredPassword, string? hashedPassword)
        {
            var hashedEnterdPassword = HashPassword(enteredPassword);
            string strHashedEnteredPassword = Convert.ToBase64String(hashedEnterdPassword);


            if (hashedEnterdPassword != null)
            {
                if (strHashedEnteredPassword.Equals(hashedPassword))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        // DELETE api/<UserApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserCreateResponseRP>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Users.Where(s => s.Id == id).FirstOrDefault<Users>();
                    if (doc != null)
                    {
                        context.Users.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return new UserCreateResponseRP
                {
                    Status = true,
                    UserID = 1,
                    Message = "User Deleted Successfully!"
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
