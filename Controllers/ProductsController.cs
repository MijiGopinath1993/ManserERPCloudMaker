using Microsoft.AspNetCore.Mvc;

namespace ERPCloudMaker.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductUnits() 
        {
            return View();
        }
        public IActionResult ProductGroups()
        {
            return View();
        }
        public IActionResult ProductCategory() 
        {
            return View();
        }
        public IActionResult ItemMaster()
        {
            return View();
        }
        public IActionResult CreateProductItems(int Id, string IsEdit)
        {
            ViewBag.Id = Id;
            ViewBag.IsEdit = IsEdit;
            return View();
        }

    }
}
