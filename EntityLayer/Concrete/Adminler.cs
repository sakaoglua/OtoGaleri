using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Adminler
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string Admin_Name { get; set; }

        [StringLength(10)]
        public string Admin_Surname { get; set; }
    }
}
