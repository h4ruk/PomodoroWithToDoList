namespace ExtendControl
{
    partial class TimeOptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeOptionForm));
            this.workTimeTb = new ExtendControl.TextboxControl();
            this.applyBtn = new ExtendControl.ButtonControl();
            this.restTimeTb = new ExtendControl.TextboxControl();
            this.SuspendLayout();
            // 
            // workTimeTb
            // 
            this.workTimeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.workTimeTb.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workTimeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.workTimeTb.Location = new System.Drawing.Point(24, 28);
            this.workTimeTb.Name = "workTimeTb";
            this.workTimeTb.Size = new System.Drawing.Size(211, 49);
            this.workTimeTb.TabIndex = 0;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.applyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.applyBtn.FlatAppearance.BorderSize = 0;
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Satoshi", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.applyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.applyBtn.Location = new System.Drawing.Point(12, 179);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Offset = 3;
            this.applyBtn.PenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.applyBtn.PenWidth = 3;
            this.applyBtn.Radius = 10;
            this.applyBtn.Size = new System.Drawing.Size(236, 50);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "APPLY";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // restTimeTb
            // 
            this.restTimeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.restTimeTb.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restTimeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.restTimeTb.Location = new System.Drawing.Point(24, 109);
            this.restTimeTb.Name = "restTimeTb";
            this.restTimeTb.Size = new System.Drawing.Size(211, 49);
            this.restTimeTb.TabIndex = 5;
            // 
            // TimeOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 252);
            this.Controls.Add(this.restTimeTb);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.workTimeTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimeOptionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TextboxControl workTimeTb;
        private ButtonControl applyBtn;
        private TextboxControl restTimeTb;
    }
}