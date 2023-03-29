using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Models
{
    public class BusDrivers:Entitiy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Age { get; set; }
        public string? Adress { get; set; }
        public Bus? Bus { get; set; }


    }
}
