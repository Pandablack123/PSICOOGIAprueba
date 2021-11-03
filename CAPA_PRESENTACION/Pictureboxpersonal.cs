using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CAPA_PRESENTACION
{
   public class Pictureboxpersonal:PictureBox
    {
        private int bordersize = 2;
        private Color bordercolor = Color.DeepSkyBlue;
        private Color bordercolor2 = Color.Cyan;
        private DashStyle borderlinestyle = DashStyle.Solid;
        private DashCap bordercapstyle = DashCap.Flat;
        private float gradient = 50f;

        public Pictureboxpersonal()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int Bordersize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        public Color Bordercolor
        {

            get 
            {
                return bordercolor; 
            }
            set
            {
                bordercolor = value;
                this.Invalidate();
            }
        }
        public Color Bordercolor2 
        {
            get
            { 
                return bordercolor2;
            }
            set 
            {
                bordercolor2 = value;
                this.Invalidate();

            }
        }
        public DashStyle Borderlinestyle 
        {
            get
                { 
                    return borderlinestyle;
                }
            set
                { 
                 borderlinestyle = value;
                this.Invalidate();
                }
        }
        public DashCap Bordercapstyle
        {
            get
            {
                return bordercapstyle;
            }

            set
            {
                bordercapstyle = value;
                this.Invalidate();

            }
        }
        public float Gradient 
        {
            get
            {
                return gradient;
            }
            set
            {
                gradient = value;
                this.Invalidate();
            }
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(Width, Height);

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectcountoursmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var recborder = Rectangle.Inflate(rectcountoursmooth, -bordersize, -bordersize);
            var smoothsize = bordersize > 0 ? bordersize * 3 : 1;
            using (var borderColor = new LinearGradientBrush(recborder, Bordercolor, Bordercolor2, gradient))
            using (var pathRegion=new GraphicsPath())
            using (var pensmooth=new Pen(this.Parent.BackColor,smoothsize))
            using (var penborder= new Pen(borderColor,bordersize))
            {
                penborder.DashStyle = borderlinestyle;
                penborder.DashCap = bordercapstyle;
                pathRegion.AddEllipse(rectcountoursmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                graph.DrawEllipse(pensmooth, rectcountoursmooth);
                if (bordersize > 0)
                    graph.DrawEllipse(penborder, recborder);
            }
        }
    }
}
