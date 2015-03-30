using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WolvenApp.Models
{
    public class Rol
    {
        public int RolID { get; set; }
        public String Naam { get; set; }
        public int Punten { get; set; }
        public int Prioriteit { get; set; }
        public String Beschrijving { get; set; }
    }
}
