using Microsoft.AspNetCore.Mvc;

namespace ERPCloudMaker.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult NumberSettings() 
        {
            return View();
        }         
        public IActionResult SaleQuotationForm() 
        {
            return View();
        }


    }
}
