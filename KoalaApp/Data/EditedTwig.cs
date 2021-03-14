using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Shared;
using DataAccessLibrary;

namespace KoalaApp.Data
{
    public class EditedTwig
    {
        public Twig Twig { get; set; }
        public NestedTwig NestedTwig { get; set; }

        public Edit Edit { get; set; }
    }
}
