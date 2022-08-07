using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext 
    {
        public DbSet<Adminler> Adminlers { get; set; }
        public DbSet<Araclar> Araclars { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Subeler> Subelers { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
    }
}
