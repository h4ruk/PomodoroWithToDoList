namespace App
{
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            this.timeBtn = new ExtendControl.ButtonControl();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // timeBtn
            // 
            this.timeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.timeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeBtn.FlatAppearance.BorderSize = 0;
            this.timeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeBtn.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.timeBtn.Location = new System.Drawing.Point(-9, -8);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Offset = 0;
            this.timeBtn.PenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.timeBtn.PenWidth = 5;
            this.timeBtn.Radius = 0;
            this.timeBtn.Size = new System.Drawing.Size(61, 377);
            this.timeBtn.TabIndex = 4;
            this.timeBtn.Text = "TIME";
            this.timeBtn.UseVisualStyleBackColor = false;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMargin = new System.Drawing.Size(10, 50);
            this.panel.AutoScrollMinSize = new System.Drawing.Size(100, 50);
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(58, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(626, 357);
            this.panel.TabIndex = 5;
            this.panel.WrapContents = false;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.timeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendControl.ButtonControl timeBtn;
        private System.Windows.Forms.FlowLayoutPanel panel;
    }
}