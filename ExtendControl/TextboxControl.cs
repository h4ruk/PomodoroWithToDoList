using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ExtendControl
{
    public partial class TextboxControl : UserControl
    {
        private bool isFocus = false;
        private TextBox textBox;
        public new string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }


        public TextboxControl()
        {
            textBox = new TextBox();
            textBox.MaxLength = 50;            
            textBox.Multiline = false;
            textBox.BorderStyle = BorderStyle.None;
            textBox.TextAlign = HorizontalAlignment.Center;

            textBox.Enter += Entering;
            textBox.Leave += Leaving;

            this.Font = ExtendFont.Satoshi20;
            this.ForeColor = ExtendColor.Black;
            this.BackColor = ExtendColor.White;
            this.SizeChanged += (obj, e) => textBox.Size = Size;

            this.Controls.Add(textBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen((isFocus ? ExtendColor.Pink : ExtendColor.Black), 5) { Alignment = PenAlignment.Center, StartCap = LineCap.Round, EndCap = LineCap.Round };
            e.Graphics.DrawLine(pen, 0, Height, Width, Height);
            pen.Dispose();
        }

        private void Entering(object sender, EventArgs e)
        {
            isFocus = true;
            this.Invalidate();
        }

        private void Leaving(object sender, EventArgs e)
        {
            isFocus = false;
            this.Invalidate();
        }
    }
}