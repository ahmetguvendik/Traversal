using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PopulerPlace
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
        public double Price { get; set; }
        public bool Statues { get; set; }
    }
}
