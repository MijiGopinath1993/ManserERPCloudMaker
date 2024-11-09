using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountPasswordVerifyApiController : ControllerBase
    {
        // GET: api/<AccountPasswordVerifyApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountPasswordVerifyApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        private Guid GenerateSecurityToken()
        {
            return Guid.NewGuid();
        }

        // POST api/<AccountPasswordVerifyApiController>
        [AllowAnonymous]
        [HttpPost]
        public async Task<int> Post([FromBody] HashedPasswordsRP verifyPassword)
        {
            int returnResult = 0;
            using (var context = new CloudDBContext())
            {
                var theUser = await context.Users.Where(x => x.UserId == verifyPassword.UserName).FirstOrDefaultAsync();
                if (theUser != null && theUser.UserPassword == null)
                {
                    //Send an email with a link to password reset because password has not been set
                    //Guid token = GenerateSecurityToken();
                    //theUser.SecurityToken = token;
                    //var res = await context.SaveChangesAsync();

                    returnResult = -1; // ----------password has not been set
                    return -1;
                }
                else if (theUser == null)
                {
                    returnResult = 0;
                    return 0; // ------------------user not available . username or/and passsword is wrong

                }
                else
                {

                    string hashedPasswordStringStored = Convert.ToBase64String(theUser.UserPassword);
                    var result = unhashAndValidatePassword(verifyPassword.Password, hashedPasswordStringStored);

                    if (theUser != null && result)
                    {
                        // if (theUser.Role != null) HttpContext.Session.SetString("LoggedInUserRole", theUser.Role);
                        if (theUser.UserId != null)
                        {
                            HttpContext.Session.SetString("LoggedInUser", theUser.UserName);
                            HttpContext.Session.SetString("LoggedinWithUserNameAndPasswordSuccess", "true");
                            HttpContext.Session.SetString("AuthenticationMethod", "PASS");
                        }
                            

                        returnResult = 1;
                        return 1;
                        //if (theUser != null  && theUser.PasswordExpiry < DateTime.Now)
                        //{
                        //    returnResult = -2; //------------ expired password
                        //    return -2;
                        //}                        
                        //else
                        //{
                        //    returnResult = 1;
                        //    return 1;
                        //}


                    }
                    else
                    {
                        return returnResult;
                    }
                }

            }
        }

        private bool unhashAndValidatePassword(string enteredPassword, string hashedPassword)
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

        public byte[] HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return hashedPassword;

        }


        // PUT api/<AccountPasswordVerifyApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountPasswordVerifyApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
