using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;


namespace CustomRoundButton
{
    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 25;
        private Color borderColor = Color.Transparent;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value; this.Invalidate();
            }
        }

        public Color TextColor = Color.White;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color DisabledTextColor { get; set; }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.FromArgb(50, 48, 48);
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI Semibold", 9f, FontStyle.Regular);
            Size = new Size(50,50);
            //if (borderRadius >= this.Height) ;
		}

        private GraphicsPath GetFigurePath(Rectangle rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();

            
            float maxRadius = Math.Min(rect.Width, rect.Height) / 2f;
            if (radius > maxRadius)
            {
                radius = maxRadius;
            }

            float curveSize = radius * 2f;
            path.StartFigure();

            
            if (curveSize > 0)
            {
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            }
            else
            {
                path.AddRectangle(rect);
            }

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize)) 
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize)) 
            using (Pen penBorder = new Pen(borderColor, borderSize)) 
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface,pathSurface);
                if(borderSize >= 1)
					pevent.Graphics.DrawPath(penBorder, pathBorder);
			}

            if (!Enabled)
            {
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                using (SolidBrush brush = new SolidBrush(DisabledTextColor))
                {
                    pevent.Graphics.DrawString(Text, Font, brush, ClientRectangle, format);
                }

            }
            else ForeColor = TextColor;
            

        }

    }
}
    

