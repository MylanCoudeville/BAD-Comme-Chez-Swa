using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommeChezSwaMylanCoudeville.Models
{
    public class Menu
    {
        public string Type { get; set; }
        public string Naam { get; set; }
        public IEnumerable<Gerecht> Gerechten { get; set; }

    }
}
