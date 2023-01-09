using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.Default
{
    public class DescriptionPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.Description = "Seyahat Etmek İnsanı Daha Akıllı Yapar, Ama Daha Az Mutlu Eder.";
            ViewBag.v2 = "Daha Fazlası";
            return View();
        }
    }
}
