using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteriler
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string M_Name { get; set; }

        [StringLength(10)]
        public string M_Surname { get; set; }

        [StringLength(20)]
        public string M_About { get; set; }
        
        [StringLength(20)]
        public string M_Unvan { get; set; }

    }
}
