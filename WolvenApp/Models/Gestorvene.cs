using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WolvenApp.Models
{
    public class Gestorvene
    {
        public int GestorveneID { get; set; }
        public int TellerNachten { get; set; }

        public virtual Bewoner Bewoner { get; set; }
    }
}