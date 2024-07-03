using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural_Activity_Monitoring_System
{
    class Points
    {
        public int x, y;
        public string name;

        public Points()
        {
        }

        public Points(string name1, int x1, int y1)
        {
            x = x1;
            y = y1;
            name = name1;
        }

        public Points[] putAllPoints()
        {
            Points[] points = new Points[14];

            points[0] = new Points("Fp1", 143, 80); points[1] = new Points("F7", 73, 137); points[2] = new Points("F3", 123, 147);
            points[3] = new Points("FC5", 103, 210); points[4] = new Points("T7", 23, 229); points[5] = new Points("P7", 123, 311);
            points[6] = new Points("O1", 143, 380); points[7] = new Points("O2", 243, 380); points[8] = new Points("P8", 264, 311);
            points[9] = new Points("T8", 363, 229); points[10] = new Points("FC6", 283, 210); points[11] = new Points("F4", 263, 147);
            points[12] = new Points("F8", 313, 136); points[13] = new Points("Fp2", 243, 80);
             
            return points;
        }
    }
}
