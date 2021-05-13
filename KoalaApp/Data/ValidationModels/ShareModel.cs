using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KoalaApp.Data.ValidationModels
{
    public class ShareModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
