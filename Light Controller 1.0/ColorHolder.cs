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
        public int brightness = 255;
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
            if(brightness < 255)
            {
                int[] color = {R, G, B};
                for (int i = 0; i < color.Length; i++) {
                    color[i] = color[i] - 255 + brightness;
                    if(color[i] < 0) color[i] = 0;
                }
                return Color.FromArgb(alpha, color[0], color[1], color[2]);
            }
            else if(brightness > 255)
            {
                int[] color = { R, G, B };
                for (int i = 0; i < color.Length; i++)
                {
                    color[i] = color[i] + brightness - 255;
                    if (color[i] > 255) color[i] = 255;
                }
                return Color.FromArgb(alpha, color[0], color[1], color[2]);
            }
            return Color.FromArgb(alpha, R, G, B);
        }

    }
}
