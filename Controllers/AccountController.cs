using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ERPCloudMaker.Controllers
{
    public class AccountController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout() 
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            return View();
        }
        public IActionResult SignUp() 
        {
            return View();
        }
    }
}
