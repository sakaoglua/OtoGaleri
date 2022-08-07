using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class KullaniciRepository : IKullanicilarDal
    {
        Context c = new Context();
        DbSet<Kullanicilar> _object;

        public void Delete(Kullanicilar p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Kullanicilar Get(Expression<Func<Kullanicilar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kullanicilar p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Kullanicilar> List()
        {
            return _object.ToList();
        }

        public List<Kullanicilar> List(Expression<Func<Kullanicilar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Kullanicilar p)
        {
            c.SaveChanges();
        }
    }
}
