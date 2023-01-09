using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutCity
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public bool Statues { get; set; }
        public string Image { get; set; }
    }
}
