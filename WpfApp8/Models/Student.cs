using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Models
{
    public class Student : Entitiy
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentName { get; set; }
        public string? SchoolNumber { get; set; }
        public string? Adress { get; set; }
    }
}
