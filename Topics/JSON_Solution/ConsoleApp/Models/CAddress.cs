using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class CAddress
    {
        public string Street { get; set; }

        public int Number { get; set; }

        public CCity City { get; set; }

    }
}
