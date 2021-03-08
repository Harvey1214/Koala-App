using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KoalaApp.Data
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [StringLength(49)]
        public string Email { get; set; }

        [Required]
        [StringLength(49)]
        public string Password { get; set; }

        [Required]
        [CompareProperty("Password")]
        public string ControlPassword { get; set; }
    }
}
