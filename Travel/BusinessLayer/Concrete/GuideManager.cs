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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Delete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public void Insert(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Guide entity)
        {
            throw new NotImplementedException();
        }
    }
}
