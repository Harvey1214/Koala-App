using Havit.Blazor.Components.Web.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Components
{
    public class KoButton : HxButton
    {
        public KoButton()
        {
            CssClass = "text-white";
            Color = ThemeColor.Info;
        }
    }
}
