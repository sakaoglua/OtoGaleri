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
    public class SubeRepository:ISubelerDal
    {
        Context c = new Context();
        DbSet<Subeler> _object;

        public void Delete(Subeler p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Subeler Get(Expression<Func<Subeler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Subeler p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Subeler> List()
        {
            return _object.ToList();
        }

        public List<Subeler> List(Expression<Func<Subeler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Subeler p)
        {
            c.SaveChanges();
        }

    }
}
