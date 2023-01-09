using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.About
{
    public class HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
