using System;
using System.Drawing;

namespace ColorToHexToolApp
{
    public class ColorToHexConverter
    {
        public static string Convert(Color? color)
        {
            if (color == null)
            {
                throw new ArgumentNullException(nameof(color));
            }

            return $"#{color.Value.R:X2}{color.Value.G:X2}{color.Value.B:X2}";
        }

        public string ColorNameToHex(string colorName)
        {
            try
            {
                Color color = Color.FromName(colorName);
                if (color.IsKnownColor)
                {
                    return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
                }
                else
                {
                    return "Color name not found.";
                }
            }
            catch
            {
                return "Invalid color name.";
            }
        }
    }
}
