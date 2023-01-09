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
    public class CustomerCommentManager : ICustomerCommentService
    {
        ICustomerCommentDal _customerComment;
        public CustomerCommentManager(ICustomerCommentDal customerComment)
        {
            _customerComment = customerComment;
        }
        public void Delete(CustomerComment entity)
        {
            throw new NotImplementedException();
        }

        public List<CustomerComment> GetAll()
        {
           return _customerComment.GetAll();
        }

        public void Insert(CustomerComment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
