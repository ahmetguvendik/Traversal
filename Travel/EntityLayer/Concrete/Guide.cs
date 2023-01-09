using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; } 
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public bool Statues { get; set; }
    }
}
