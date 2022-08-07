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
    public class MusteriManager : IMusteriService
    {
        IMusterilerDal _musterilerDal;
        public MusteriManager(IMusterilerDal musterilerDal)
        {
            _musterilerDal = musterilerDal;
        }
        public Musteriler GetByID(int id)
        {
            return _musterilerDal.Get(x => x.Id == id);
        }

        public List<Musteriler> GetList()
        {
            return _musterilerDal.List();
        }

        public void MusteriAdd(Musteriler musteriler)
        {
            _musterilerDal.Insert(musteriler);
        }

        public void MusteriDelete(Musteriler musteriler)
        {
            _musterilerDal.Delete(musteriler);
        }

        public void MusteriUpdate(Musteriler musteriler)
        {
            _musterilerDal.Update(musteriler);
        }
    }
}
