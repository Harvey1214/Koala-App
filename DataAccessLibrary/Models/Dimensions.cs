using System;

namespace DataAccessLibrary
{
    public class Dimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Dimensions() { }
        public Dimensions(string input)
        {
            if (input == null) return;

            string[] parts = input.Split(';');
            if (parts.Length == 2)
            {
                {
                    int width = 0;
                    bool success = Int32.TryParse(parts[0], out width);
                    if (success) Width = width;
                }

                {
                    int height = 0;
                    bool success = Int32.TryParse(parts[1], out height);
                    if (success) Height = height;
                }
            }
        }

        public override string ToString()
        {
            return $"{Width};{Height}";
        }
    }
}
