using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KoalaApp.Data.ValidationModels
{
    public class NewTreeModel
    {
        [Required]
        [StringLength(49, MinimumLength = 1)]
        public string Name { get; set; }
    }
}
