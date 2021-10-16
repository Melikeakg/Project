using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class ThemeColors
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
        {
            "#3f51b5",
            "#ff5722",
            "#607d8b",
            "#2196f3",
            "#e41a4a",
            "#5978bb",
            "#018790",
            "#721d47",
            "#f37521",
            "#a12059",
            "#126881",
            "#365d5b",
            "#43b76e",
            "#800080",
            "#b71c46",
            "#7D9978",
            "#4B6734",
            "#814660",
            "#607d8b",
            "#4d3663"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);

        }
    }
}
