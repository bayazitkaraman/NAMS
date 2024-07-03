using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Neural_Activity_Monitoring_System
{
    internal class Colors
    {
        public Colors()
        {
        }

        public Color[] putAllColors()
        {
            Color[] colors = new Color[14];

            colors[0] = Color.Blue; colors[1] = Color.DarkGreen; colors[2] = Color.DarkMagenta;
            colors[3] = Color.DarkOrange; colors[4] = Color.DarkRed; colors[5] = Color.Fuchsia;
            colors[6] = Color.Olive; colors[7] = Color.Red; colors[8] = Color.Purple;
            colors[9] = Color.Maroon; colors[10] = Color.Blue; colors[11] = Color.DarkGreen;
            colors[12] = Color.DarkMagenta; colors[13] = Color.DarkOrange; 

            return colors;

        }

        public Color[] putAllAmplitudes()
        {
            Color[] amplitude = new Color[7];

            amplitude[0] = Color.Navy; amplitude[1] = Color.RoyalBlue; amplitude[2] = Color.LightSkyBlue;
            amplitude[3] = Color.DarkOrange; amplitude[4] = Color.OrangeRed; amplitude[5] = Color.Red;

            //new
            amplitude[6] = Color.Red;
            return amplitude;
        }
    }
}
