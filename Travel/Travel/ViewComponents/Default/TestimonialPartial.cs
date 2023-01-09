using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace Travel.ViewComponents.Default
{
    public class TestimonialPartial : ViewComponent 
    {
        CustomerCommentManager commentManager = new CustomerCommentManager(new EfCustomerCommentDal());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.GetAll();
            return View(values);
        }

    }
}
