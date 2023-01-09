using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.Default
{
    public class PopularDestinations : ViewComponent
    {
        PopularDestinationManager popularDestination = new PopularDestinationManager(new EfPopularDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = popularDestination.GetAll();
            return View(values);
        }
    }
}
