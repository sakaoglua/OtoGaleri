using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubeService
    {
        List<Subeler> GetList();
        void SubeAdd(Subeler subeler);
        Subeler GetByID(int id);
        void SubeDelete(Subeler subeler);
        void SubeUpdate(Subeler subeler);
    }
}
