using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubeManager : ISubeService
    {
        ISubelerDal _subelerDal;

        public SubeManager(ISubelerDal subelerDal)
        {
            _subelerDal = subelerDal;
        }

        public void SubeAdd(Subeler subeler)
        {
            _subelerDal.Insert(subeler);
        }

        public void SubeDelete(Subeler subeler)
        {
            _subelerDal.Delete(subeler);
        }

        public void SubeUpdate(Subeler subeler)
        {
            _subelerDal.Update(subeler);
        }

        public Subeler GetByID(int id)
        {
            return _subelerDal.Get(x => x.Id == id);
        }

        public List<Subeler> GetList()
        {
            return _subelerDal.List();
        }
    }
}
