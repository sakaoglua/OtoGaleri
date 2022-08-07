using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Araclar
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(15)]
        public string A_Marka { get; set; }
        
        [StringLength(10)]
        public string A_Plaka { get; set; }
        public int M_Id { get; set; }
    }
}
