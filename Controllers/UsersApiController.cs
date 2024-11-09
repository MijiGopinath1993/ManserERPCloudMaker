using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        // GET: api/<UsersApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        public byte[] HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return hashedPassword;

        }
        // PUT api/<UsersApiController>/5 
        public async Task<ActionResult<UserCreateResponseRP>> Put(Users users)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    byte[] hashedPassword = HashPassword(users.UserPasswordHash);

                    Users _users = context.Users.FirstOrDefault(item => item.Id == users.Id);

                    bool res = unhashAndValidatePassword(users.UserPasswordHash, Convert.ToString(_users.UserPasswordHash));

                    if (res)
                    {
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
        public bool unhashAndValidatePassword(string enteredPassword, string? hashedPassword)
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

        // DELETE api/<UsersApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
