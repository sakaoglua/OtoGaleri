using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMusteriService
    {
        List<Musteriler> GetList();
        void MusteriAdd(Musteriler musteriler);
        void MusteriDelete(Musteriler musteriler);
        void MusteriUpdate(Musteriler musteriler);
        Musteriler GetByID(int id);

    }
}
