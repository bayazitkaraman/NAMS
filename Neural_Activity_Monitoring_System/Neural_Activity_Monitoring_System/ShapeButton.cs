using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Neural_Activity_Monitoring_System
{
    class ShapeButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(Point.Empty, this.Size));
            this.Region = new Region(gp);
        }
    }
}
