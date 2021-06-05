using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoalaApp.Data
{
    public static class UISettings
    {
        private static Theme Theme { get; } = Theme.CYAN;

        public static string PrimaryColor
        {
            get
            {
                switch (Theme)
                {
                    case Theme.CYAN:
                        return "#17A2B8";
                    case Theme.BLUE:
                        return "#007BFF";
                    default:
                        return "#17A2B8";
                }
            }
        }
        public static string PrimaryButton
        {
            get
            {
                switch (Theme)
                {
                    case Theme.CYAN:
                        return "btn-info";
                    case Theme.BLUE:
                        return "btn-primary";
                    default:
                        return "btn-info";
                }
            }
        }
        public static string PrimaryOutlineButton
        {
            get
            {
                switch (Theme)
                {
                    case Theme.CYAN:
                        return "btn-outline-info";
                    case Theme.BLUE:
                        return "btn-outline-primary";
                    default:
                        return "btn-outline-info";
                }
            }
        }

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
