using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WolvenApp.Auth
{
    public class UserRole
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}