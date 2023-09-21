using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ExtendControl
{
    public partial class ButtonControl : Button
    {        
        private int offset;
        private int radius;
        private int penWidth;
        private Color penColor;

        [Category("Draw")]
        public int Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = value;
                Invalidate();
            }
        }

        [Category("Draw")]
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        [Category("Draw")]
        public int PenWidth
        {
            get
            {
                return penWidth;
            }
            set
            {
                penWidth = value;
                Invalidate();
            }
        }

        [Category("Draw")]
        public Color PenColor
        {
            get
            {
                return penColor;
            }
            set
            {
                penColor = value;
                Invalidate();
            }
        }        

        public ButtonControl()
        {
            this.Paint += Painting;
            this.MouseEnter += MouseEntering;
            this.MouseLeave += MouseLeaving;

            this.Font = ExtendFont.Satoshi32;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            this.BackColor = ExtendColor.White;
            this.ForeColor = ExtendColor.Black;

            //draw
            offset = 3;
            radius = 10;
            penWidth = 3;
            penColor = ExtendColor.BlueBerry;
        }

        private void Painting(object sender, PaintEventArgs e)
        {
            DrawShape(e.Graphics);
        }
        private void DrawShape(Graphics graphics)
        {
            //setup            
            Pen pen = new Pen(penColor, penWidth) { Alignment = PenAlignment.Outset };
            GraphicsPath path = new GraphicsPath();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //points
            Point start, end;
            Point topleft = new Point(offset, offset);
            Point topright = new Point(Width - offset, offset);
            Point botright = new Point(Width - offset, Height - offset);
            Point botleft = new Point(offset, Height - offset);

            //topleft curve
            start = new Point(topleft.X, topleft.Y + radius);
            end = new Point(topleft.X + radius, topleft.Y);
            path.AddBezier(start, topleft, topleft, end);

            //topright curve
            start = new Point(topright.X - radius, topright.Y);
            end = new Point(topright.X, topright.Y + radius);
            path.AddBezier(start, topright, topright, end);

            //botright curve
            start = new Point(botright.X, botright.Y - radius);
            end = new Point(botright.X - radius, botright.Y);
            path.AddBezier(start, botright, botright, end);

            //botleft curve
            start = new Point(botleft.X + radius, botleft.Y);
            end = new Point(botleft.X, botleft.Y - radius);
            path.AddBezier(start, botleft, botleft, end);

            //final line
            start = new Point(botleft.X, botleft.Y - radius);
            end = new Point(topleft.X, topleft.Y + radius);
            path.AddLine(start, end);

            //done                        
            graphics.DrawPath(pen, path);
            pen.Dispose();
            path.Dispose();                      
        }

        public void MouseEntering(object obj, EventArgs args)
        {
            this.ForeColor = ExtendColor.Pink;
            this.penColor = ExtendColor.Pink;
            this.BackColor = ExtendColor.White;
            this.Invalidate();
        }

        public void MouseLeaving(object obj, EventArgs args)
        {
            this.ForeColor = ExtendColor.Black;
            this.penColor = ExtendColor.BlueBerry;
            this.BackColor = ExtendColor.White;
            this.Invalidate();
        }
    }
}