using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WolvenApp.Models
{
    public class Bewoner
    {
        public virtual Persoon Persoon;
        public virtual Rol? Rol;
        public virtual Dorp? Dorp;
    }
}