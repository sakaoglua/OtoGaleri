using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracService
    {
        List<Araclar> GetList();
        void AracAdd(Araclar araclar);
        Araclar GetByID(int id);
        void AracDelete(Araclar araclar);
        void AracUpdate(Araclar araclar);
    }
}
