using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullanicilarDal _kullanicilarDal;

        public KullaniciManager(IKullanicilarDal kullanicilarDal)
        {
            _kullanicilarDal = kullanicilarDal;
        }

        public Kullanicilar GetByID(int id)
        {
            return _kullanicilarDal.Get(x=>x.Id==id); 
        }

        public List<Kullanicilar> GetList()
        {
            return _kullanicilarDal.List();    
        }

        public void KullaniciAdd(Kullanicilar kullanicilar)
        {
            _kullanicilarDal.Insert(kullanicilar);
        }

        public void KullaniciDelete(Kullanicilar kullanicilar)
        {
            _kullanicilarDal.Delete(kullanicilar);
        }

        public void KullaniciUpdate(Kullanicilar kullanicilar)
        {
            _kullanicilarDal.Update(kullanicilar);
        }
    }
}
