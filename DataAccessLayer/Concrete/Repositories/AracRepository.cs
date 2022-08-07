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
    public class AracRepository : IAraclarDal
    {
        Context c = new Context();
        DbSet<Araclar> _object;

        public void Delete(Araclar p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Araclar Get(Expression<Func<Araclar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Araclar p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Araclar> List()
        {
            return _object.ToList();
        }

        public List<Araclar> List(Expression<Func<Araclar, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Araclar p)
        {
            c.SaveChanges();
        }
    }
}