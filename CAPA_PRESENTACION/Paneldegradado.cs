using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public class Paneldegradado : Panel
    {
        public Color Colorrigth { get; set; }
        public Color Colorleft { get; set; }
        public float angulo { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.Colorleft, this.Colorrigth,this.angulo);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);

        }
    }
}
