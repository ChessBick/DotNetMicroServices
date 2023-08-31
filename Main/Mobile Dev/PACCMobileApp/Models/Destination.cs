using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACCMobileApp.Models
{
    public class Destination
    {
        public string Place { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string About { get; set; }
        public List<Gallary> gallary { get; set; }
    }
}
