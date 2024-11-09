using Microsoft.AspNetCore.Mvc;

namespace ERPCloudMaker.Controllers
{
    public class MastersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employee() 
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult CreateCustomer(int CustId, string IsEdit)
        {
            ViewBag.CustId = CustId;
            ViewBag.IsEdit = IsEdit;
            return View();
        }
        public IActionResult AccountGroup()
        {
            return View();
        }
        public IActionResult Suppliers()
        {
            return View();
        }
        public IActionResult CreateSupplier(int SupId, string IsEdit)
        {
            ViewBag.SupId = SupId;
            ViewBag.IsEdit = IsEdit;
            return View();
        }
        public IActionResult Ledgers() 
        {
            return View();
        } 
        
        public IActionResult CreateLedger(int AccId, string IsEdit)
        {
            ViewBag.AccId = AccId;
            ViewBag.IsEdit = IsEdit;
            return View();
        }
        public IActionResult SupplierDetails()
        {
            return View();
        }

    }
}
