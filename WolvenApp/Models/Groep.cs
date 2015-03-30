using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WolvenApp.Models
{
    public class Groep
    {
        public int GroepID { get; set; }
        public int Grootte { get; set; }

        public virtual Reservatie Reservatie { get; set; }
        public virtual ICollection<Persoon> Personen { get; set; }
    }
}