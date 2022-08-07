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
    public class AracManager : IAracService
    {
        IAraclarDal _araclarDal;

        public AracManager(IAraclarDal araclarDal)
        {
            _araclarDal = araclarDal;
        }

        public void AracAdd(Araclar araclar)
        {
            _araclarDal.Insert(araclar);
        }

        public void AracDelete(Araclar araclar)
        {
            _araclarDal.Delete(araclar);
        }

        public void AracUpdate(Araclar araclar)
        {
            _araclarDal.Update(araclar);
        }

        public Araclar GetByID(int id)
        {
            return _araclarDal.Get(x => x.Id == id);
        }

        public List<Araclar> GetList()
        {
            return _araclarDal.List();
        }

    }
}
