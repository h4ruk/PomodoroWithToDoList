using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendControl
{
    public delegate void PomodoroSettingHandler(int workTime, int restTime); 

    public partial class TimeOptionForm : Form
    {
        public event PomodoroSettingHandler PomodoroSetting;

        public TimeOptionForm()
        {
            InitializeComponent();
            BackColor = ExtendColor.White;
            workTimeTb.Text = "Work";
            restTimeTb.Text = "Rest";
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (
                Int32.TryParse(workTimeTb.Text, out int workTime) &&
                Int32.TryParse(workTimeTb.Text, out int restTime)
            )
            {
                PomodoroSetting?.Invoke(workTime, restTime);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
