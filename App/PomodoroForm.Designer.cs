namespace App
{
    partial class PomodoroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskBtn = new ExtendControl.ButtonControl();
            this.settings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Satoshi", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(167, 46);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(415, 187);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Black;
            this.startBtn.Font = new System.Drawing.Font("Satoshi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(257, 293);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(234, 56);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // taskLabel
            // 
            this.taskLabel.Font = new System.Drawing.Font("Satoshi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(89, 233);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(566, 33);
            this.taskLabel.TabIndex = 3;
            this.taskLabel.Text = "Work on";
            this.taskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskBtn
            // 
            this.taskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.taskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.taskBtn.FlatAppearance.BorderSize = 0;
            this.taskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskBtn.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.taskBtn.Location = new System.Drawing.Point(-8, -8);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Offset = 0;
            this.taskBtn.PenColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.taskBtn.PenWidth = 0;
            this.taskBtn.Radius = 0;
            this.taskBtn.Size = new System.Drawing.Size(60, 377);
            this.taskBtn.TabIndex = 0;
            this.taskBtn.Text = "TASKS";
            this.taskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskBtn.UseVisualStyleBackColor = false;
            this.taskBtn.Click += new System.EventHandler(this.taskBtn_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(634, 3);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(38, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 4;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // PomodoroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.taskBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PomodoroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PomodoroForm";
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendControl.ButtonControl taskBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.PictureBox settings;
    }
}