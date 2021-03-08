using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KoalaApp.Data.ValidationModels
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [StringLength(49)]
        public string Email { get; set; }

        [Required]
        [StringLength(49)]
        public string Password { get; set; }
    }
}
