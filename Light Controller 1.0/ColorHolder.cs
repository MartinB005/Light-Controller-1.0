using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Controller_1._0
{
    public class ColorHolder
    {
        public int R;
        public int G;
        public int B;
        public int alpha;

        public static ColorHolder fromColor(Color color)
        {
            ColorHolder colorHolder = new ColorHolder();
            colorHolder.R = color.R;
            colorHolder.G = color.G;
            colorHolder.B = color.B;
            colorHolder.alpha = color.A;
            return colorHolder;
        }

        public Color createColor()
        {
            return Color.FromArgb(alpha, R, G, B);
        }

    }
}
