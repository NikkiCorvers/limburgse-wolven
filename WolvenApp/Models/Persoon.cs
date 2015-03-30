using System;
using System.Collections.Generic;

namespace WolvenApp.Models
{
    public class Persoon
    {
        public int PersoonID { get; set; }
        public string Naam { get; set; }
        public string Emailadres { get; set; }

        public virtual Reservatie Reservatie { get; set; }
    }
}