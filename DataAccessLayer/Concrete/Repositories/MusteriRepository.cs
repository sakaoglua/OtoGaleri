using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class MusteriRepository:IMusterilerDal
    {
        Context c = new Context();
        DbSet<Musteriler> _object;

        public void Delete(Musteriler p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Musteriler Get(Expression<Func<Musteriler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Musteriler p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Musteriler> List()
        {
            return _object.ToList();
        }

        public List<Musteriler> List(Expression<Func<Musteriler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Musteriler p)
        {
            c.SaveChanges();
        }
    }
}
