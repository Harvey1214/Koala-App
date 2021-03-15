using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Data.Common
{
    public static class UISettings
    {
        public static float MarginMultiplier { get; } = 2;
        public static float MarginHighlightAddittion { get; } = 2;
        public static string[] LevelStyles { get; } = { "text-white bg-dark", "bg-light", "text-white bg-info", "text-white bg-secondary" };
        public static string[] LevelHighlightStyles { get; set; } = { "", "border-dark", "", "" };
    }
}
