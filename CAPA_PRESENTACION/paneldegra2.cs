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
     public class paneldegra2: Panel
    {
        public Color Colorrigth { get; set; }
        public Color Colorleft { get; set; }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle,this.Colorrigth, this.Colorleft,90f);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);

        }
    }
}
