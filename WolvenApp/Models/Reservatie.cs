using System;
using System.Collections.Generic;

namespace WolvenApp.Models
{
    public class Reservatie
    {
        public int ResID { get; set; }
        public bool Betaald { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual ICollection<Groep> Groepen { get; set; }
        public virtual ICollection<Persoon> Personen { get; set; }
    }
}