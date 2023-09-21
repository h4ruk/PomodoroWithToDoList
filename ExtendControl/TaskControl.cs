using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ExtendControl
{
    public delegate void TaskHandler(int index);

    public partial class TaskControl : Control
    {        
        private int offset;
        private int radius;
        private int tail;
        private int penWidth;
        private int boxWidth;
        private int maxBoxWidth;
        private Color penColor;
        private Color brushColor;
        private Color textColor;

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
        public int Tail
        {
            get
            {
                return tail;
            }
            set
            {
                tail = value;
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
        public int MaxBoxWidth
        {
            get
            {
                return maxBoxWidth;
            }
            set
            {
                maxBoxWidth = value;
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

        [Category("Draw")]
        public Color BrushColor
        {
            get
            {
                return brushColor;
            }
            set
            {
                brushColor = value;
                Invalidate();
            }
        }

        [Category("Draw")]
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                Invalidate();
            }
        }

        public int Index;
        public event TaskHandler Clicked;
        public event TaskHandler DoubleClicked;

        public TaskControl()
        {
            Init();
            InitializeComponent();
        }

        private void Init()
        {
            Index = 0;
            offset = 3;
            penWidth = 3;
            radius = 10;
            tail = 5;
            maxBoxWidth = 527;
            penColor = ExtendColor.BlueBerry;
            brushColor = ExtendColor.White;
            textColor = ExtendColor.Black;
            TextChanged += OnTextChanged;
            Click += OnClicked;
            DoubleClick += OnDoubleClicked;
        }

        private void OnDoubleClicked(object sender, EventArgs e)
        {
            DoubleClicked?.Invoke(Index);   
        }

        private void OnClicked(object sender, EventArgs e)
        {            
            Clicked?.Invoke(Index);
        }

        private void OnTextChanged(object sender, System.EventArgs e)
        {
            boxWidth = (Text.Length < 4) ? 24 + 16 * Text.Length : 16 * Text.Length;
            if (boxWidth > maxBoxWidth) boxWidth = maxBoxWidth;
            Size = new Size(boxWidth, 40);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            DrawShape(pe.Graphics);
            DrawString(pe.Graphics);
        }

        private void DrawShape(Graphics graphics)
        {
            //setup            
            Pen pen = new Pen(penColor, penWidth) { Alignment = PenAlignment.Outset };
            GraphicsPath path = new GraphicsPath();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //points
            Point start, end;
            Point topleft = new Point(offset + tail, offset);
            Point topright = new Point(Width - offset, offset);
            Point botright = new Point(Width - offset, Height - offset);
            Point botleft = new Point(offset + tail, Height - offset);

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

            //tail
            int boxheight = Height - 2 * offset;
            start = new Point(offset + tail, offset + (2 * boxheight / 3));
            end = new Point(offset, offset + boxheight / 2);
            path.AddLine(start, end);
            start = new Point(offset + tail, offset + boxheight / 3);
            end = new Point(topleft.X, topleft.Y + radius);
            path.AddLine(start, end);

            //fill shape
            Brush brush = new SolidBrush(brushColor);
            graphics.FillPath(brush, path);
            brush.Dispose();

            //done
            graphics.DrawPath(pen, path);
            pen.Dispose();
            path.Dispose();
        }

        private void DrawString(Graphics graphics)
        {
            Font font = new Font("Satoshi", 16);
            Brush brush = new SolidBrush(textColor);
            graphics.DrawString(Text, font, brush, offset + tail + penWidth, offset + penWidth);

            font.Dispose();
            brush.Dispose();
        }
    }
}
