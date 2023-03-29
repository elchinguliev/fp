using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Models
{
    public class Bus : Entitiy
    {
        public string Brand { get; set; }
        public string RelaysDate { get; set; }
        public string SerialNumber { get; set; }
        public string SeatCount { get; set; }
    }
}
