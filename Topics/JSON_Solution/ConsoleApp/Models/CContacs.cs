using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class CContacs
    {
        public string Name { get; set; }

        public CAddress Address { get; set; }

        public List<CPhone> Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
