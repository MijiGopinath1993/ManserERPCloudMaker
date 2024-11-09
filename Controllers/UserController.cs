using ERPCloudMaker.DataBaseContext;
using Microsoft.AspNetCore.Mvc;

namespace ERPCloudMaker.Controllers
{
    public class UserController : Controller
    { 
        public IActionResult Index() 
        {
            using (var context = new CloudDBContext())
            {
                //List<Users> user = context.Users.Where(a => a.FirstName == "Miji").ToList();
                //user.Status = true;
                //var result = context.SaveChangesAsync();
            }
            return View();
        }
    }
}
