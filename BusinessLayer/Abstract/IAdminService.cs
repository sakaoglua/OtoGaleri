using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Adminler> GetList();
        void AdminAdd(Adminler adminler);
        Adminler GetByID(int id);
        void AdminDelete(Adminler adminler);
        void AdminUpdate(Adminler adminler);
    }
}
