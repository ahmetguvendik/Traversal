using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.About
{
    public class AboutInfoBarPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            using var c = new Context();
            ViewBag.v1 = "250";
            ViewBag.v2 = c.PopulerDestinations.Count();
            ViewBag.v3 = "5";
            return View();
        }
    }
}
