using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanicilar> GetList();
        void KullaniciAdd(Kullanicilar kullanicilar);
        Kullanicilar GetByID(int id);
        void KullaniciDelete(Kullanicilar kullanicilar);
        void KullaniciUpdate(Kullanicilar kullanicilar);
    }
}
