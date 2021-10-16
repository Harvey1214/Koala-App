using Havit.Blazor.Components.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Components
{
    public class KoSubmit : HxSubmit
    {
        public KoSubmit()
        {
            CssClass = "text-white";
            Color = ThemeColor.Info;
        }
    }
}
