using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string K_Adi { get; set; }
        public int K_Sifre { get; set; }
    }
}
