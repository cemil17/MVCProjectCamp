using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(8)]
        public string Password { get; set; }

        public ICollection<Heading> Headings { get; set; } // Bir yazar birden çok başlıkta yazabilir
        public ICollection<Content> Contents { get; set; }
    }
}
