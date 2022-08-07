using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Subeler
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string S_Name { get; set; }
    }
}
