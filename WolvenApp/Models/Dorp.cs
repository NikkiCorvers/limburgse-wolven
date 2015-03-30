using System;
using System.Collections.Generic;

namespace WolvenApp.Models
{
    public class Dorp
    {
        public int DorpID { get; set; }
        public string Naam { get; set; }

        public virtual ICollection<Rol>? Rollen { get; set; }
    }
}