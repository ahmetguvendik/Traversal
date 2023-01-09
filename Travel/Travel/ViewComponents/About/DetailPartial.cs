using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.About
{
    public class DetailPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {      
            return View();
        }
    }
}
