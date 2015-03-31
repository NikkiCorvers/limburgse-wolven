using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WolvenApp.Models;

namespace WolvenApp.Auth
{
    public class UserProfile
    {
        [Required(ErrorMessage = "Please tell us your name")]
        [DisplayName("Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Choose a displayname for yourself")]
        [DisplayName("Displayname")]
        public string DisplayName { get; set; }

        public string Picture { get; set; }

        [Required(ErrorMessage = "Please enter an e-mail address")]
        [DisplayName("E-Mail-Address")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
            ErrorMessage = "Please provide a valid e-mailaddress")]
        public string Email { get; set; }

        [Key]
        public string UserId { get; set; }

        public IdentityProvider? Provider { get; set; }

        public virtual Dorp Dorp { get; set; }
    }

    public enum IdentityProvider
    {
        Google = 0,
        Twitter = 1,
        Facebook = 2
    }
}