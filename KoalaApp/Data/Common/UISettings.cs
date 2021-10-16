using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Data
{
    public static class UISettings
    {
        private static Theme Theme { get; } = Theme.BLUE;

        public static float MarginMultiplier { get; } = 2;
        public static string[] LevelStyles 
        {
            get
            {
                switch (Theme)
                {
                    case Theme.CYAN:
                        return new string[] { "text-white bg-dark", "bg-light", $"text-white bg-info", "text-white bg-secondary" };
                    case Theme.BLUE:
                        return new string[] { "text-white bg-dark", "bg-light", $"text-white bg-primary", "text-white bg-secondary" };
                    default:
                        return new string[] { "text-white bg-dark", "bg-light", $"text-white bg-info", "text-white bg-secondary" };
                }
            }
        }
    }

    public enum Theme
    {
        CYAN,
        BLUE
    }
}
