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
    public class AdminManager : IAdminService
    {
        IAdminlerDal _adminlerDal;

        public AdminManager(IAdminlerDal adminlerDal)
        {
            _adminlerDal = adminlerDal;
        }

        public void AdminAdd(Adminler adminler)
        {
             _adminlerDal.Insert(adminler);
        }

        public void AdminDelete(Adminler adminler)
        {
            _adminlerDal.Delete(adminler);
        }

        public void AdminUpdate(Adminler adminler)
        {
            _adminlerDal.Update(adminler);
        }

        public Adminler GetByID(int id)
        {
            return _adminlerDal.Get(x => x.Id == id);
        }

        public List<Adminler> GetList()
        {
            return _adminlerDal.List();
        }
    }
}
