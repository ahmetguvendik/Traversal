using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PopularDestinationManager :IPopularDestinationService
    {
        IPopularDestinationDal _popularDestination;

        public PopularDestinationManager(IPopularDestinationDal popularDestination)
        {
            _popularDestination= popularDestination;
        }

        public void Delete(PopulerDestination entity)
        {
            throw new NotImplementedException();
        }

        public List<PopulerDestination> GetAll()
        {
          return _popularDestination.GetAll();
        }

        public void Insert(PopulerDestination entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PopulerDestination entity)
        {
            throw new NotImplementedException();
        }
    }
}
